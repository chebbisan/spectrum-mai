namespace Fourier;

public class Complex
{
    private double _Re;
    private double _Im;

    public double Re
    {
        get
        {
            return _Re;
        }
        set
        {
            _Re = value;
        }
    }

    public double Im
    {
        get
        {
            return _Im;
        }
        set
        {
            _Im = value;
        }
    }

    public Complex(double real, double imag)
    {
        Re = real;
        Im = imag;
    }

    public Complex()
    {
        Re = 0;
        Im = 0;
    }

    public double GetAbs()
    {
        return Math.Sqrt(Re * Re + Im * Im);
    }

    public double GetArg()
    {
        return Math.Atan2(Im, Re);
    }
    
    public void Print()
    {

        Console.WriteLine("z = {0} + {1}i \nabs = {2} \narg = {3}", 
            this.Re, 
            this.Im, 
            this.GetAbs(), 
            this.GetArg());
    }
}
