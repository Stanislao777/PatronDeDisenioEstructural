class Multiplicar : OperacionMatematica
{
	double a;
	double b;

	public Multiplicar(double a, double b)
	{
		this.a = a;
		this.b = b;
	}

	public double calcular()
	{
		return a * b;
	}
}
