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

			Console.WriteLine("Checked Unchecked");

			//ProcessBytes(); Проверка и обнаружение переполнения типа данных short byte int long decimal

			DeclareImplicitVars();

		}
		
		static void NarrowingAttemp()
		{
			byte myByte = 0;
			int myInt = 200;

			myByte = (byte)myInt;
			Console.WriteLine("Value of my byte {0}", myByte);
		}//Сужающее преобразование данных

		static int Add(int x, int y)
		{
			return x + y;
		}

		static void ProcessBytes()
		{
			byte b1 = 100;
			byte b2 = 200;

			try
			{
				checked
				{
					byte sum = (byte)Add(b1, b2);
					Console.WriteLine("Here is the sum fo bytes {0}", sum);
				}
			}

			catch (OverflowException ex)
			{
				Console.WriteLine(ex.Message);
			}
	

			
		}

		static void DeclareImplicitVars() //Использование неявно типизированных переменных
		{

			var myInt = 34444;
			var myString = "Time marches on ....";
			var myBool = true;

			//Используем рефлексию типа .GetType

			Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
			Console.WriteLine("myString is a: {0}", myString.GetType().Name);
			Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);

			//var не может применяться к полям и к возвращаемому значению или типу параметра
			//К переменным типа var нельзя присвоить значение NULL или оставлять их без значения вовсе


			Console.WriteLine("Press enter to see the reference type of var");
			Console.ReadLine();


			var newInt = 355;
			var anotherNewInt = newInt;
			Console.WriteLine(anotherNewInt);

			//Неявная типизация является строготипизированным видом данных
			//Нельзя присваивать значение другого типа в уже объявленную переменную сделанную неявным типизированием














		}

	}
}
