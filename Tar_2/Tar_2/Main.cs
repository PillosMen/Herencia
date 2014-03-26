using System;

namespace Tar_2
{
	class MainClass 
	{
		public static void Main (string[] args)
		{
			Funciones ob=new Funciones();

			ob.mostrarNombre();
			ob.suma();
			ob.salida();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
