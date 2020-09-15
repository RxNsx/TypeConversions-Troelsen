using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversions
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Practice with type conversions");

			short numb1, numb2;

			numb1 = 3000;
			numb2 = 30000;

			short answer = (short)Add(numb1, numb2);//Принудительное суживающее преобразование

			Console.WriteLine("{0} + {1} = {2}", numb1, numb2, answer);

			NarrowingAttemp();

		}
		
		static void NarrowingAttemp()
		{
			byte myByte = 0;
			int myInt = 200;

			myByte = (byte)myInt;
			Console.WriteLine("Value of my byte {0}", myByte);
		}

		static int Add(int x, int y)
		{
			return x + y;
		}
	}
}
