namespace com.alipay.ams.api.entities;

public class Individual
{
    public UserName Name { get; set; }
    public UserName EnglishName { get; set; }
    public string DateOfBirth { get; set; }
    public Address PlaceOfBirth { get; set; }
    public Certificate Certificates { get; set; }
    public string Nationality { get; set; }
    public Contact[] Contacts { get; set; }
}