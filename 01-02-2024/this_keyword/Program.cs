class Calculation
{
    private int a;
    private int b;
    public Calculation():this(1,2)
    {
        
    }
    public Calculation(int a,int b)
    {
        this.a = a;
        this.b = b;
    }
    
    public int getA()
    {
        return a;
    }
    public int getB()
    {
        return b;
    }
}

class Program
{
    public static void Main(String[] args)
    {
        Calculation c = new Calculation();
        Console.WriteLine(c.getA());
        Console.WriteLine(c.getB());

    }
}