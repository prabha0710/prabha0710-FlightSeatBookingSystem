using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection.PortableExecutable;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FlightSeatBookingSystem_Task
{
	public static class Program
	{
		
		

		static List<string> list = new List<string>();
		static string[] array = new string[50];
		
		static void Main(string[] args)
		{

			
			BookFlight();

		}
		
		private static  string[] Layoutgenerate()
		{
			 string[] Characters = new string[5] { "A", "B", "C", "D", "E" };
			string[,] seats;
			Console.WriteLine("W    " + "M   " + "A   " + "A   " + "W   ");
			for(int i = 9; i >= 0; i--)
			{
				for(int j = 0; j < Characters.Length; j++)
				{
					Console.Write(seats[i, j] = $"{(i + 1) + Characters[j]}" + "   ");

				}
				Console.WriteLine();

			}
		}

		private static void BookFlight()
		{
			bool loopstring = true;
			while(loopstring)
			{
				array = list.ToArray();
				Console.WriteLine("Enter a 1 for Book , 2 for Exist , Othervise please type a Requiremen1");

				int Status = int.Parse(Console.ReadLine());
				if(Status == 1)
				{
					string[] seats = Layoutgenerate();
					Console.WriteLine("Please Enter a Seat Number \n W-Window \n M-Middle \n A- Aisle");
					string seatNo = Console.ReadLine();

					Checkseat(seatNo, seats);

				}
				else
				{
					Console.WriteLine("Thank You !");
					loopstring = false;
				}

			}
		}

		private static void Checkseat(string? seatNo, string[] seats)
		{
			if(array.Count() != 0)
			{
				int i = 0;
				while(i < array.Length)
				{
					if(array[i] == seatNo)
					{
						Console.WriteLine("Seat is already Booked");
						ShowAvaliableSeat(seats, array);
						break;
					}

					else
					{
						bookseat(seatNo);
						break;
					}

					i++;
				}
			}
			else
			{

				bookseat(seatNo);

			}
		}

		private static void ShowAvaliableSeat(string[] seats, string[] array)
		{

			Console.WriteLine("Please select the seat from the avaliable seat");
			Console.WriteLine("Booked Seats a Marked as a X");
			for(int i = 0; i < 10; i++)
			{
				for(int j = 0; j < 5; j++)
				{
					if((array.Length >= j) && (array[j] != seats[i, j]))
					{
						seats[i, j] = seats[i, j] + "(X)";
					}
					else
					{
						seats[i, j] = seats[i, j] + "(A)";
					}

				}
			}
			Console.WriteLine("W    " + "M   " + "A   " + "A   " + "W   ");
			for(int i = 0; i < 10; i++)
			{
				for(int j = 0; j < 5; j++)
				{
					Console.Write(seats[i, j] + "   ");
				}
				Console.WriteLine();
			}
		}

		public static void bookseat(string seatNo)
		{
			list.Add(seatNo);
			array = list.ToArray();
			Console.WriteLine("Booked");
		}
		
	}
}