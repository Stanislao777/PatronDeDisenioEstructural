class Dividir : OperacionMatematica
{
	double a;
	double b;

	public Dividir(double a, double b)
	{
		this.a = a;
		this.b = b;
	}

	public double calcular()
	{
		return a / b;
	}
}
