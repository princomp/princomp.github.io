class Class1
{
    private string attribute1;
    public void SetAttribute1(string aP) { attribute1 = aP; }
    public string Property1 { get; set; }
}
class Class2 : Class1
{
    public string Property2 { get; set; }
}
