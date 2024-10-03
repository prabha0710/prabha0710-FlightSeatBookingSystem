using System;

namespace FlightSeatBookingSystem_Task
{
	internal class Program
	{
		static void Main(string[] args)
		{

			string status = "Book";
			BookFlight(status);
		}

	

		public static void BookFlight(string status)
		{


			string[,] seats = { { "10A", "10B", "10C","10D","10E" }  ,
								{ "9A", "9B", "9C","9","9E" },
								{ "8A", "8B", "8C","8D","8E" },
								{ "7A", "7B", "7C","7D","7E" },
								{ "6A", "6B", "6C","6D","6E" },
							   { "5A", "5B", "5C","5D","5E" },
								{ "4A", "4B", "4C","4D","4E" } ,
								{ "3A", "3B", "3C","3D","3E" },
								 { "2A", "2B", "2C","2D","2E" },
								  { "1A", "1B", "1C","1D","1E" },};

			

			Console.WriteLine("Welcome To Flights Booking");
			Console.WriteLine("Please type 1 if you want to book Flight \n Otherwise Please specify the requirement");
			int Status = int.Parse(Console.ReadLine());
			int[] booked = new booked[50];
			if(Status == 1)
			{
				Console.WriteLine("W    " + "M   " + "A   " + "A   " + "W   ");
				for(int i = 0; i < 10; i++)
				{
					for(int j = 0; j < 5; j++)
					{
						Console.Write(seats[i, j] +"   ");
					}
					Console.WriteLine();
				}
				Console.WriteLine("Please Enter a Seat Number \n W-Window \n M-Middle \n A- Aisle") ;

				string seatsNo = Console.ReadLine();
				bool Avaliable = true; 
				
					int n=1;
					for(int i=0;i<n;i++)
					{
						if(booked[i] != 0)
						{
						n++;
						}
						booked[i] += int.Parse(seatsNo);
						Console.WriteLine("Booked");
					}
				

			
				
			}

		}
	}


}
