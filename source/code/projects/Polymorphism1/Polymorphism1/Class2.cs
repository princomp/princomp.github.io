class Class2 : Class1
{
    public string Property2 { get; set; }
    
    public Class2(string p1P, string p2P, string a1P){
      base.SetAttribute1(a1P);
      // The following would not work.
      // attribute1 = a1P;
      base.Property1 = p1P;
      Property2 = p2P;
    }
}
