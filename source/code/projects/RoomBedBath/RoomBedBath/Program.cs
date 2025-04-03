using System;

class Program
{
  static void Main(string[] args)
  {
        Room rTest = new Room(12, 11.8);
        Console.WriteLine(rTest);

        try
        {
            BedRoom beTest1 = new BedRoom(10, 9, -3);
        }
        catch(Exception ex) { Console.WriteLine(ex); }

        BedRoom beTest = new BedRoom(10, 9, 3);
        try
        {
            beTest.Capacity =  -3;
        }
        catch (Exception ex) { Console.WriteLine(ex); }

        BathRoom baTest = new BathRoom(3, 4, true, false, false);
        Console.WriteLine(baTest);
        BathRoom baTest1 = new BathRoom(3, 4, false, false, true);
        Console.WriteLine(baTest1);
        BathRoom baTest2 = new BathRoom(3, 4, false, true, false);
        Console.WriteLine(baTest2);
        BathRoom baTest3 = new BathRoom(3, 4, true, true, true);
        Console.WriteLine(baTest3);

        // rTest.Capacity = 12;
        // Error CS1061: 'Room' does not contain a definition for 'Capacity' and no accessible extension method 'Capacity' accepting a first argument of type 'Room' could be found (are you missing a using directive or an assembly reference?) (CS1061) (RoomBedBath)

        baTest.Width = 12;
        // Ok

        // beTest.capacity = 3;
        // 'BedRoom.capacity' is inaccessible due to its protection level(CS0122) (RoomBedBath)

        // rTest.SurfaceArea = -2;
        // Error CS0200: Property or indexer 'Room.SurfaceArea' cannot be assigned to -- it is read only (CS0200) (RoomBedBath)

       // baTest.Capacity = 3;
        // Error CS1061: 'BathRoom' does not contain a definition for 'Capacity' and no accessible extension method 'Capacity' accepting a first argument of type 'BathRoom' could be found (are you missing a using directive or an assembly reference?) (CS1061) (RoomBedBath)

        // beTest.Shower = true;
        // 'BedRoom' does not contain a definition for 'Shower' and no accessible extension method 'Shower' accepting a first argument of type 'BedRoom' could be found(are you missing a using directive or an assembly reference ?) (CS1061)(RoomBedBath)

        Console.WriteLine(baTest.ToString());

    }
}
