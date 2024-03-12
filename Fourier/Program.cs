using Fourier;

Complex[] GetSpectrum(double[] signal)
{
    var n = signal.Length;
    Complex[] spectre = new Complex[signal.Length];
    
    for (var m = 0; m < n; ++m)
    {
        double sr = 0;
        double si = 0;
        
        for (var i = 0; i < n; ++i)
        {
            sr += signal[i] * Math.Cos(2 * Math.PI * i * m / n);
            si += signal[i] * Math.Sin(2 * Math.PI * i * m / n);
        }
        Complex s = new Complex(sr / n, si / n);
        spectre[m] = s;
    }
    return spectre;
}

