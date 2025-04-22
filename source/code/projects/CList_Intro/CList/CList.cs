using System;

public class CList<T>
{
  // A CList is … a Cell.
  private Cell first;

  // By default, a CList contains only an empty cell.
  public CList()
  {
    first = null;
  }
  // A Cell is itself two things:
  // - An element of data (of type T),
  // - Another cell, containing the next element of data.
  // We implement this using automatic properties:
  private class Cell
  {
    public T Data { get; set; }
    public Cell Next { get; set; }

    public Cell(T dataP, Cell nextP)
    {
      Data = dataP;
      Next = nextP;
    }
  }

  // A method to add a cell at the beginning
  // of the CList (to the left).
  // We call it AddF for 'Add First'.
  public void AddF(T dataP)
  {
    first = new Cell(dataP, first);
  }
  // The updated CList starts with a cell holding dataP and 
  // a Cell referencing the previous first cell.
}
