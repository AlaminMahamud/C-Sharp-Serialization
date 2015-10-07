Person p = new Person {name = "Stacey", Age=30};
var ds = new DataContractSerializer(typeof(Person));

using (Stream s = File.Create("person.xml"))
	ds.WriteObject(s,p); // Serialize

Person p2;
using (Stream s = File.OpenRead("person.xml"))
	p2 = (Person) ds.ReadObject(s);

Console.WriteLine(p2.Name + " " + p2.Age);