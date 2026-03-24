// Class for family members.
// Family members are person
// with an additional relationship
// attribute.
class FMember : Person
{
  public string Relationship;

  public FMember(string relationP, string nameP)
  {
    // This implicitely calls
    // Person()
    // which exists to create first
    // a person object.
    Relationship = relationP;
    // the following
    // name = nameP;
    // gives
    // error CS0122: 'Person.name' is inaccessible due to its protection level
    // so we have to use the public method instead:
    SetName(nameP);
    // the following
    // NewName(nameP);
    // gives
    //  error CS0122: 'Person.NewName(string)' is inaccessible due to its protection level
  }
}
