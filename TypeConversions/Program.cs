using System;
using System.Linq;

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

			//IfElseExample(); Использование if else и логических операций && || !=

			//SwitchCasePractice();

			SwitchEnumPractice();

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

			Console.WriteLine(conditionalTest.Length > 0
				? "string is greater than 0 symbols"
				: "string IS NOT greater than 0 symbols");



			string nameGirl = "Marina";

			Console.WriteLine(nameGirl.Length < 0
				? "string is not smaller than 0 symbols"
				: "string is smaller than 0 symbols");

			Console.WriteLine();


			//Логические операции
			/*
			 * && возвращает true если все выражения дают true (имееи значение"И") 
			 *
			 * || возвращает true или false если одно из выражений даёт true или false (имеет значение "ИЛИ")
			 *
			 * ! возвращает false если выражение даёт true и наоборот (имеет значение "НЕ")
			 *
			 *
			 */

			string Sasha, Juja;
			Sasha = "Alexandra";
			Juja = "Jujolda";


			//Сравнение двух строк через логические операции

			if (Sasha != Juja)
			{
				Console.WriteLine("Alexandra");
			}
			else
			{
				Console.WriteLine("Jujolda");
			}







		}

		static void SwitchCasePractice()
		{

			//Использование SWITCH CASE первый раз


			//Console.WriteLine("1 [C#], 2 [VB]");
			//Console.WriteLine("Please pick you language preference");

			//string enteredMessage = Console.ReadLine();
			//int enteredNumber = int.Parse(enteredMessage);

			//switch (enteredMessage)
			//{
			//	case "1":
			//		Console.WriteLine("C# is a good choice");
			//		break;
			//	case "2":
			//		Console.WriteLine("VB is a good choice");
			//		break;
			//	default:
			//		Console.WriteLine("Well good luck with {0}", enteredMessage);
			//		break;
			//}


			//Выборка по мороженному в цикле, когда выбираешь одно и подтверждаешь, предлагает выбрать следующее


			//	Console.WriteLine("Here is a few of ice creams");
			//	Console.WriteLine("[Sundae], [Donduma], [Banana Split], [Sanwich], [Gelato]");

			//Start:
			//	string iceCream = Console.ReadLine();



			//	while (iceCream == "Sundae" || iceCream == "Donduma" || iceCream == "Banana Split" || iceCream == "Sanwich" || iceCream == "Gelato")
			//	{

			//		switch (iceCream)
			//		{
			//			case "Sundae":
			//				Console.WriteLine("Sundae is the most popular ice cream here, thank you");
			//				break;
			//			case "Donduma":
			//				Console.WriteLine("Donudma is a great choice");
			//				break;
			//			case "Banana Split":
			//				Console.WriteLine("Banana Split is so tasty");
			//				break;
			//			case "Sanwich":
			//				Console.WriteLine("Sanwich like a SAND WITCH cmon");
			//				break;
			//			case "Gelato":
			//				Console.WriteLine("Gelato is a good italion icecream very tasty and so tastyfull (hm ok)");
			//				break;

			//			default:
			//				Console.WriteLine("You're better be thinking what u want to get");
			//				break;
			//		}

			//		Console.WriteLine("\nChoose your ice cream");
			//		goto Start;
			//	}



			//Автомат с подсчётом денег и забивом количества штук 

			Console.WriteLine("Choose your item from the market");
			Console.WriteLine(" 1: Tomato\n 2: Potato\n 3: Milk\n 4: Tea\n 5: Chocolate\n");

			StartItem:
			string selectedItem = Console.ReadLine();
			int selectedItemNumber = int.Parse(selectedItem);

			

			// Счётчик денег
			int cost = 0;
			int finallCost = 0;

			switch (selectedItemNumber)
			{
				case 1:
					Console.WriteLine("You got a tomato. Nice!");
					cost += 25;
					break;

				case 2:
					Console.WriteLine("You got a potato. Nice!");
					cost += 30;
					break;

				case 3:
					Console.WriteLine("You got milk. Nice!");
					cost += 35;
					break;

				case 4:
					Console.WriteLine("You got a tea. Good!");
					cost += 20;
					break;

				case 5:
					Console.WriteLine("You got a chocolate. Very tasty!");
					cost += 60;
					break;

				default:
					Console.WriteLine("Try to enter number again to choose the item you really need");
					goto StartItem;
					break;
			}

			Console.WriteLine("Your full cost is {0}", cost);
			Console.WriteLine("How many do you need of this? Maximum value is 5");

			StartValue:
			string valueOfItems = Console.ReadLine();
			int numberOfItems = int.Parse(valueOfItems);

			

			switch (numberOfItems)
			{
				case 1:
					finallCost = cost * numberOfItems;
					Console.WriteLine("Your final cost of all items is {0}",finallCost);
					break;

				case 2:
					finallCost = cost * numberOfItems;
					Console.WriteLine("Your final cost of all items is {0}",finallCost);
					break;

				case 3:
					finallCost = cost * numberOfItems;
					Console.WriteLine("Your final cost of all items is {0}",finallCost);
					break;

				case 4:
					finallCost = cost * numberOfItems;
					Console.WriteLine("Your final cost of all items is {0}",finallCost);
					break;

				case 5:
					finallCost = cost * numberOfItems;
					Console.WriteLine("Your final cost of all items is {0}",finallCost);
					break;


				default:
					Console.WriteLine("Enter a new number here");
					goto StartValue;
					break;
			}


			//



		}

		static void SwitchEnumPractice()
		{
			Console.WriteLine("Enter your favourite DayofWeek:");

			DayOfWeek favday;

			try
			{
				favday = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
			}
			catch (Exception)
			{
				Console.WriteLine("Bad input");
				return;
			}

			switch (favday)
			{
				case DayOfWeek.Monday:
					Console.WriteLine("Another day another coding day");
					break;

				case DayOfWeek.Tuesday:
					Console.WriteLine("Wake up and code on CSharp!");
					break;

				default:
					Console.WriteLine("Cmon you need to code more in your life to get a good money and an awesome projects for more fun in life");
					break;
			}
		}




	}
}








