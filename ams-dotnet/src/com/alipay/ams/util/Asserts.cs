using System;
using com.alipay.ams.api.entities;

namespace com.alipay.ams.util
{
    public static class Asserts
    {
        public static void NotNull(object argument, string msg)
        {
            if (argument == null)
                throw new ArgumentNullException(msg);
        }
        public static void AssertTrue(bool _true, string msg)
        {
            if (!_true)
                throw new ArgumentException(msg);
        }
    }
}
