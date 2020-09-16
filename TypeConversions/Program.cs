using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

			//DeclareImplicitVars();

			//IterationCyclesPractice();

			IfElseExample();

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



		}//checked unchecked проверка для суживающих преобразований данных и предотвращения или сокрытия переполнения переменной

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

		static void IterationCyclesPractice()
		{

			//4 вида циклов
			/*
			 * for
			 * foreach/in
			 * while
			 * do/while
			*/

			//Когда требуется повторять блок кода определенное количество раз, заранее известное, лучшим вариантом будет цикл FOR
			//goto break continue может использоваться в любом виде цикла


			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine("For cycle there");
			}

			//foreach идеальный цикл для перебора массива данных
			//foreach шагает n+1 и никак по другому
			//List<T> может применятся внутри цикла foreach

			string[] sportCars = { "Mazda", "Honda", "Subaru", "Suzuki", "Toyota", "Ford" };
			foreach (string cars in sportCars)
			{
				Console.WriteLine(cars);
			}

			int[] engineNumbers = { 240, 320, 560, 400, 600, 720 };
			foreach (int eNumbers in engineNumbers)
			{
				Console.WriteLine(eNumbers);
			}

			//Неявная типизация в foreach

			int[] bibNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			var subset = from i in bibNumbers where i < 10 select i;

			Console.Write("Values in subset\n");

			foreach (var i in bibNumbers)
			{
				Console.Write(" {0}\n", i);
			}

			//while цикл
			//Повторяет цикл до того момента пока условие не будет выполнено

			string userIsDone = "";
			//проверка копии строки в нижнем регистре
			while (userIsDone.ToLower() != "yes")
			{
				Console.WriteLine("We are in the while loop");
				Console.WriteLine("Submit [yes] or [no] in the console to next iteration");
				userIsDone = Console.ReadLine();
			}

			Console.WriteLine("Yor are done the loop");


			//do while цикл - используется когда цикл должен выполниться неопределенное количество раз

			string userIsDone2 = "";

			do
			{
				Console.WriteLine("In do/while loop");
				Console.WriteLine("Are you done [yes] [no]");
				userIsDone2 = Console.ReadLine();
			}

			while (userIsDone2.ToUpper() != "NO");

		}//4 вида циклов for foreach while (do while - для неопределенного количества раз)

		static void IfElseExample()//If else может обрабатывать только Boolean значения, исключение - значение равное 0
		{

			string casualData = "My casual Data";
			string casualDataCopy = "My casual DataCopy";

			if (casualData.Length == casualDataCopy.Length)
			{
				Console.WriteLine("Hello!");
			}

			else
			{
				Console.WriteLine("casualData not Equal casualDataCopy");
			}

			//Условные операции ? :

			string conditionalTest = "Asus";

			Console.WriteLine(conditionalTest.Length >0
				? "string is greater than 0 symbols"
				: "string IS NOT greater than 0 symbols");


		}




	}
}
			







