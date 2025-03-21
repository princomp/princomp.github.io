using System;

class Reptile : Animal
{
  private bool ossifiedScale;

  public Reptile(
    string conservationStatusP,
    double populationP,
    string wikiLinkP,
    bool ossifiedScaleP
  )
    : base(conservationStatusP, populationP, wikiLinkP)
  {
    ossifiedScale = ossifiedScaleP;
  }

  public override string ToString()
  {
    return base.ToString()
      + String.Format(
        "| {0,-20} | {1,-40}\n",
        "Ossified Scales",
        ossifiedScale
      );
  }
}
