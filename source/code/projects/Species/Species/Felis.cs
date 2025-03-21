using System;

class Felis : Mammal
{
  private string furPattern;

  public Felis(
    string conservationStatusP,
    double populationP,
    string wikiLinkP,
    string furPatternP
  )
    : base(conservationStatusP, populationP, wikiLinkP, 8)
  {
    furPattern = furPatternP;
  }

  public override string ToString()
  {
    return base.ToString()
      + String.Format(
        "| {0,-20} | {1,-40}\n",
        "Fur pattern",
        furPattern
      )
      + String.Format(
        "| {0,-20} | {1,-40}\n",
        "Sound(s) produced",
        Felis.SoundProduced()
      );
  }

  public static string SoundProduced()
  {
    return "mew, meow, purr, hiss, trill, caterwaul, growl";
  }
}
