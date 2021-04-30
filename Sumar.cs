class Sumar : OperacionMatematica
{
	double a;
	double b;

	public Sumar(double a, double b)
	{
		this.a = a;
		this.b = b;
	}

	public double calcular()
	{
		return a + b;
	}
}
