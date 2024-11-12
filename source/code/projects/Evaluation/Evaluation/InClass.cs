class InClass : Exam
{
  public string Room { get; set; }

  public InClass(
    string courseP,
    double weightP,
    bool bonusP,
    string roomP
  )
    : base(courseP, weightP, bonusP)
  {
    Room = roomP;
  }

  public override string GetRoom()
  {
    string returnRoom;
    if (string.IsNullOrEmpty(Room))
    {
      returnRoom = "Same as class meeting room.";
    }
    else
    {
      returnRoom = Room;
    }
    return returnRoom;
  }
}
