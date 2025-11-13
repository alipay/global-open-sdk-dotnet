using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Individual
    {

        public Individual() { }

        

        public Individual(  UserName  name ,  UserName  englishName ,  string  dateOfBirth ,  Address  placeOfBirth ,  List<Certificate>  certificates ,  string  nationality ,  List<Contact>  contacts)
        {
            this.Name = name;
            this.EnglishName = englishName;
            this.DateOfBirth = dateOfBirth;
            this.PlaceOfBirth = placeOfBirth;
            this.Certificates = certificates;
            this.Nationality = nationality;
            this.Contacts = contacts;
        }

            public  UserName  Name { get; set; }
            public  UserName  EnglishName { get; set; }
            public  string  DateOfBirth { get; set; }
            public  Address  PlaceOfBirth { get; set; }
            public  List<Certificate>  Certificates { get; set; }
            public  string  Nationality { get; set; }
            public  List<Contact>  Contacts { get; set; }

        

    }

}
