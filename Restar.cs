class Restar : OperacionMatematica
{
	double a;
	double b;

	public Restar(double a, double b)
	{
		this.a = a;
		this.b = b;
	}

	public double calcular()
	{
		return a - b;
	}
}
