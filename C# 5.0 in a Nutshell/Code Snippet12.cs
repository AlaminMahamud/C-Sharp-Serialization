static Person DeepClone (Person p)
{
	var ds = new DataContractSerializer (typeof (Person));
	MemoryStream stream = new MemoryStream();
	ds.WriteObject (stream, p);
	stream.Position = 0;
	return (Person) ds.ReadObject (stream);
}
