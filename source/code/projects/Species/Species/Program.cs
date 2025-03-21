using System;

class Program
{
  static void Main()
  {
    // Helper string, to display more nicely
    string sep = "\n\n" + new String('*', 20) + "\n\n";

    /*
     * The following are given as indications that
     * both Animal and Mammal should be implemented as
     * abstract classes. Creating an object
     * in those classes should give you errors.
     */

    // Animal test = new Animal("EX", 12, "https://en.wikipedia.org/wiki/test");
    // Should return the error
    // Error CS0144: Cannot create an instance of the abstract type or interface 'Animal' (CS0144) (Species)
    // if uncommented.

    // Mammal AfricanPygmyHedgehog = new Mammal("LC", 1000000, "https://en.wikipedia.org/wiki/Four-toed_hedgehog", 2);
    // Should return the error
    // Error CS0144: Cannot create an instance of the abstract type or interface 'Mammal' (CS0144) (Species)
    // if uncommented.

    /*
     * We now create a couple of objects from proper species.
     * The following should not return exceptions.
     */

    /*
     * We start with objects in the Felis class:
     */
    Felis JungleCat = new Felis(
      "LC",
      10,
      "https://en.wikipedia.org/wiki/Jungle_cat",
      "uniformly sandy, reddish-brown or grey fur without spots"
    );
    Console.Write(JungleCat + sep);
    // Population is estimated, cf. https://www.aloki.hu/pdf/1804_58735890.pdf for more details.
    Felis HouseCat = new Felis(
      "LC",
      6e5,
      "https://en.wikipedia.org/wiki/Cat",
      "solid, tabby, pointed, tuxedo, calico, or tortoiseshell"
    );
    Console.Write(HouseCat + sep);
    Felis PallasCat = new Felis(
      "LC",
      58,
      "https://en.wikipedia.org/wiki/Pallas%27s_cat",
      "light grey with black zigzags and stripes"
    );
    Console.Write(PallasCat + sep);
    /*
     * We now have Bat objects:
     */
    Bat AnjouanMyotis = new Bat(
      "DD",
      -1,
      "https://en.wikipedia.org/wiki/Anjouan_myotis",
      2,
      0
    );
    Console.Write(AnjouanMyotis + sep);
    Bat BlackEaredFlyingFox = new Bat(
      "VU",
      .4,
      "https://en.wikipedia.org/wiki/Black-eared_flying_fox",
      2,
      22
    ); //Flight speed given in mph
    Console.Write(BlackEaredFlyingFox + sep);
    Bat DesmodusDraculae = new Bat(
      "EX",
      0,
      "https://en.wikipedia.org/wiki/Desmodus_draculae",
      2,
      0
    );
    Console.Write(DesmodusDraculae + sep);

    /*
    * Finally, one Reptile object:
    */
    Reptile BallPython = new Reptile(
      "NT",
      .1,
      "https://en.wikipedia.org/wiki/Ball_python",
      false
    );
    Console.Write(BallPython + sep);
    /*
     * We now test our improper values handling.
     */
    try
    {
      Felis test1 = new Felis(
        "INVALID CODE",
        1,
        null,
        null
      );
    }
    catch (Exception e)
    {
      Console.WriteLine(e.Message);
    }
    try
    {
      Felis test2 = new Felis(
        "EX",
        10,
        "https://en.wikipedia.org/wiki/whatever",
        null
      );
    }
    catch (Exception e)
    {
      Console.WriteLine(e.Message);
    }
    try
    {
      Felis test3 = new Felis(
        "EX",
        0,
        "http://sketchy-website.com/",
        null
      );
    }
    catch (Exception e)
    {
      Console.WriteLine(e.Message);
    }
    try
    {
      Bat test4 = new Bat("LC", -10, null, 0, 12);
    }
    catch (Exception e)
    {
      Console.WriteLine(e.Message);
    }
    try
    {
      Bat test5 = new Bat(
        "LC",
        10,
        "https://en.wikipedia.org/wiki/whatever",
        3,
        0
      );
    }
    catch (Exception e)
    {
      Console.WriteLine(e.Message);
    }
  }
}
