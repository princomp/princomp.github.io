class Computer{
    private string brand;
    public void SetBrand(string brandP){ brand = brandP; }
    public Computer(string bP){ SetBrand(bP); }
    public override string ToString(){ return $"Brand: {brand}"; }        
}
