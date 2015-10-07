[DataContract] public class Person
{
	[DataMember] public string Name;
	[DataMember] public int Age;
}
[DataContract] public class Student : Person { }
[DataContract] public class Teacher : Person { }

