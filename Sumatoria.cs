using System.Collections.Generic;

class Sumatoria : OperacionMatematica
{
	List<OperacionMatematica> operaciones;

	public Sumatoria()
	{
		operaciones = new List<OperacionMatematica>();		
	}

	public void agregarOperacion(OperacionMatematica operacion)
	{
		operaciones.Add(operacion);
	}

	public double calcular()
	{
		double resultado = 0;
		foreach(OperacionMatematica operacion in operaciones)
		{
			resultado += operacion.calcular();	
		}
		return resultado;
	}	
}
