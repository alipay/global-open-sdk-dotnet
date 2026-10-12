using System;

namespace com.alipay.ams.util
{
    public static class AmountUtil
    {
        private const int MaxValueLength = 16;

        public static string ToAmount(string amount, string currency)
        {
            int minorUnit = MinorUnit(currency);
            if (amount == null) throw new ArgumentNullException(nameof(amount), "INVALID_ARGUMENT_TYPE: amount must be a string");
            int point = -1;
            for (int index = 0; index < amount.Length; index++)
            {
                char character = amount[index];
                if (character == '.' && point < 0 && index > 0 && index < amount.Length - 1)
                    point = index;
                else if (character < '0' || character > '9')
                    Fail("INVALID_AMOUNT_FORMAT", "amount must be an unsigned ASCII decimal string");
            }
            if (amount.Length == 0)
                Fail("INVALID_AMOUNT_FORMAT", "amount must be an unsigned ASCII decimal string");
            string whole = point < 0 ? amount : amount.Substring(0, point);
            string fraction = point < 0 ? "" : amount.Substring(point + 1);
            if (fraction.Length > minorUnit)
            {
                if (!AllZeros(fraction.Substring(minorUnit)))
                    Fail("EXCESS_PRECISION", "amount exceeds the currency minor unit");
                fraction = fraction.Substring(0, minorUnit);
            }
            fraction = fraction.PadRight(minorUnit, '0');
            string value = CanonicalDigits(whole + fraction);
            ValidateCanonical(value, currency);
            return value;
        }

        public static string FromAmount(string value, string currency)
        {
            int minorUnit = MinorUnit(currency);
            ValidateValueFormat(value);
            string canonical = CanonicalDigits(value);
            if (minorUnit == 0) return canonical;
            string padded = canonical.PadLeft(minorUnit + 1, '0');
            int point = padded.Length - minorUnit;
            return padded.Substring(0, point) + "." + padded.Substring(point);
        }

        public static void Validate(string value, string currency)
        {
            MinorUnit(currency);
            ValidateValueFormat(value);
            ValidateCanonical(value, currency);
        }

        private static int MinorUnit(string currency)
        {
            if (currency == null) throw new ArgumentNullException(nameof(currency), "INVALID_ARGUMENT_TYPE: currency must be a string");
            if (currency.Length != 3 || !IsUpperAscii(currency[0]) || !IsUpperAscii(currency[1]) || !IsUpperAscii(currency[2]))
                Fail("INVALID_CURRENCY", "currency must be three uppercase ASCII letters");
            AmountRuleSet rules = AmountRuleLoader.Rules;
            if (!rules.Currencies.TryGetValue(currency, out int? minorUnit))
                Fail("UNSUPPORTED_CURRENCY", "currency is not supported by AmountUtil");
            if (!minorUnit.HasValue)
                throw new InvalidOperationException("RULE_DATA_ERROR: supported currency has no numeric minor unit");
            return minorUnit.Value;
        }

        private static void ValidateValueFormat(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value), "INVALID_ARGUMENT_TYPE: value must be a string");
            if (value.Length == 0) Fail("INVALID_VALUE_FORMAT", "value must contain ASCII digits only");
            foreach (char character in value)
                if (character < '0' || character > '9') Fail("INVALID_VALUE_FORMAT", "value must contain ASCII digits only");
            if (value.Length > MaxValueLength) Fail("VALUE_TOO_LONG", "value must contain at most 16 digits");
        }

        private static void ValidateCanonical(string value, string currency)
        {
            if (value.Length > MaxValueLength) Fail("VALUE_TOO_LONG", "value must contain at most 16 digits");
            if (AllZeros(value)) return;
            if (AmountRuleLoader.Rules.Multiples.TryGetValue(currency, out string multiple))
            {
                string suffix = multiple.Substring(1);
                if (!value.EndsWith(suffix, StringComparison.Ordinal))
                    Fail("RULE_VIOLATION", "value does not satisfy the Antom currency constraint");
            }
        }

        private static string CanonicalDigits(string value)
        {
            int index = 0;
            while (index < value.Length - 1 && value[index] == '0') index++;
            return value.Substring(index);
        }

        private static bool AllZeros(string value)
        {
            foreach (char character in value) if (character != '0') return false;
            return true;
        }

        private static bool IsUpperAscii(char value) => value >= 'A' && value <= 'Z';

        private static void Fail(string category, string detail)
        {
            throw new ArgumentException(category + ": " + detail);
        }
    }
}
