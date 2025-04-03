class BathRoom : Room
{
    private bool hotWater;
    public bool Shower { get; set; }
    public bool Bathtub { get; set; }
    public BathRoom(double wP, double lP, bool hwP, bool sP, bool bP) : base(wP, lP){
        hotWater = hwP;
        Shower =  sP;
        Bathtub = bP;
        }

        // ToString method
    public override string ToString()
{
    string equipement = "";
    if (Shower) { equipement += "a shower"; }
    if (Shower && Bathtub) { equipement += " and "; }
    if (Bathtub) { equipement += "a bathtub"; }
        if (!Shower && !Bathtub) equipement += "no shower nor bathtub";
    equipement += ".";
    if (!hotWater && (Shower || Bathtub))
    {
        equipement += " However, it does not have hot water";
    }

        return base.ToString() + "\nThis bathtub has " + equipement; 
}
// End of ToString method
}
