[DataContract] public class Person
{
[DataMember] public string Name;
[DataMember] public int Age;
[DataMember] public Address HomeAddress;
}
[DataContract] public class Address
{
[DataMember] public string Street, Postcode;
}