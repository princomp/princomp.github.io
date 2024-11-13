class Room
{
  private string building;
  private int number;

  public Room(string bP, int nP)
  {
    building = bP;
    number = nP;
  }

  public override string ToString()
  {
    return building + " " + number;
  }

  // Question 2
  // (not on UML diagram)
  public static bool SameBuilding(Room a, Room b)
  {
    return a.building == b.building;
  }
  // Note that since we are inside the class,
  // we can access the attributes of the arguments.
}
