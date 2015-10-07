var ds  = new DataContractSerializer(typeof(Person), new Type[] {typeof(USAddress)});

[DataContract] public class Person
{
	...
	[DataMember] public Address HomeAddress, WorkAddress;
}
