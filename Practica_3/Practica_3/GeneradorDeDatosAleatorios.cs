using System;
using System.Text;

namespace Practica_3
{

	public class GeneradorDeDatosAleatorios
	{
		
		Random random = new Random();
		
		public GeneradorDeDatosAleatorios()
		{
			
		}
		
		
		public int numeroAleatorio(int max)
		{
			return this.random.Next(0, max);
		}
		
		public string stringAleatorio(int cant=5)
		{
			const string alfabeto = "abcdefghijklmnopqrstuvwxyz1234567890";
			StringBuilder token = new StringBuilder();
			
			for (int i = 0; i < cant; i++)
			{
				int indice = random.Next(alfabeto.Length);
				token.Append(alfabeto[indice]);
			}
			
			return token.ToString();
		}
		
	}
}
