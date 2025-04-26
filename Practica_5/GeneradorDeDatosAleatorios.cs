using System;
using System.Text;

namespace Practica_5
{

	public class GeneradorDeDatosAleatorios
	{
		
		private static Random random = new Random();
		
		public GeneradorDeDatosAleatorios()
		{
			
		}
		
		
		public int numeroAleatorio(int max)
		{
			return random.Next(0, max);
		}
		
		public double doubleAleatorio(double max)
		{
			return Math.Round(random.NextDouble() * max, 1);
		}
		
		public string stringAleatorio(int cant=5)
		{
			const string alfabeto = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
			StringBuilder token = new StringBuilder();
			
			for (int i = 0; i < cant; i++)
			{
				int indice = random.Next(alfabeto.Length);
				token.Append(alfabeto[indice]);
			}
			
			return token.ToString();
		}
		
		
		// Nuevo metodo para generar nombres aleatorios (mas completo)
		public string nombreAleatorio()
        {
            string[] nombres = { "Santiago", "Maria", "Pedro", "Ana", "Luis", "Laura", "Carlos", "Sofia", "Javier", "Isabel" };
            string[] apellidos = { "Lovisotto", "Lopez", "Martinez", "Hernandez", "Garcia", "Perez", "Sanchez", "Ramirez", "Torres", "Diaz" };

            string nombre = nombres[numeroAleatorio(nombres.Length)];
            string apellido = apellidos[numeroAleatorio(apellidos.Length)];
            
            return nombre + " " + apellido;
        }
		
	}
}
