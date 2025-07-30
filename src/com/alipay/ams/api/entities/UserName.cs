    
namespace com.alipay.ams.api.entities
{

public class UserName
    {

        public UserName() { }

        public UserName( string firstName , string middleName , string lastName , string fullName)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.FullName = fullName;
        }

            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }
            public string FullName { get; set; }

        

    }

}
