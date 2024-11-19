public abstract class Shape : IAnimation, IComparable<Shape>
{
    private string color;
    public string GetColor()
    {
        return color;
    }
    private bool filled;
    public bool GetFilled()
    {
        return filled;
    }

    public Shape (string color, bool filled)
    {
        this.color = color;
        this.filled = filled;
    }
    public override string ToString()
    {
        return "[color=" + color + ", filled=" + filled + "]";
    }
    public abstract double Area();
    public abstract void Talk();
    public abstract void FlipRight();
    public int CompareTo(Shape shapeP)
    {
        if (this.Area() > shapeP.Area())
            return 1;
        else if (this.Area() < shapeP.Area())
            return -1;
        else
            return 0;
    }
}
