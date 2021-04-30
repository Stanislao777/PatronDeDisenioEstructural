using System;

class MainClass
{
	public static void Main (string[] args)
	{
		Sumatoria s1 = new Sumatoria();
		for(int i = 1; i <= 10; ++i)
		{
			s1.agregarOperacion(new Multiplicar(i, 2));
		}
		Sumatoria s2 = new Sumatoria();
		s2.agregarOperacion(s1);
		s2.agregarOperacion(new Sumar(5, 4));
		s2.agregarOperacion(new Multiplicar(1, 2));
		s2.agregarOperacion(new Dividir(8, 3));
		s2.agregarOperacion(new Dividir(4, 7));
		s2.agregarOperacion(new Multiplicar(3, 1));
		s2.agregarOperacion(new Restar(6, 12));

		Console.WriteLine("resultado = {0}", s2.calcular());
	}
}
