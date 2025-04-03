class Room
{
  public double Width { get; set; }
  public double Length { get; set; }

  // SurfaceArea property
  public double SurfaceArea
  {
    get { return Width * Length; }
  }

  // Constructor

  public Room(double wP, double lP)
  {
    Width = wP;
    Length = lP;
  }

  public override string ToString()
  {
    return "This room is "
      + Width
      + " x "
      + Length
      + "\nSurface: "
      + SurfaceArea;
  }
}
