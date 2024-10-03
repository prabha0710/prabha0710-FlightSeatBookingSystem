namespace FlightSeatBookingSystem_Task
{
	public static class Program
	{
		static List<string> list = new List<string>();
		static string[] array = new string[50];
		private static object passengerDetails;

		public static object Name { get; private set; }
		public static object Gender { get; private set; }
		public static object Age { get; private set; }

		static void Main(string[] args)
		{
			BookFlight();
		}

		private static string[,] Layoutgenerate()
		{
			string[] Characters = new string[5] { "A", "B", "C", "D", "E" };
			string[,] TotalSeats = new string[10, 5];

			Console.WriteLine("W    " + "M   " + "A   " + "A   " + "W   ");
			for(int i = 9; i >= 0; i--)
			{
				for(int j = 0; j < Characters.Length; j++)
				{
					TotalSeats[i, j] = $"{(i + 1) + Characters[j]}";
					Console.Write(TotalSeats[i, j] + "   ");
				}
				Console.WriteLine();
			}
			return TotalSeats;
		}

		private static void BookFlight()
		{
			bool loopstring = true;
			while(loopstring)
			{
				array = list.ToArray();
				Console.WriteLine(
					"------------------Welcome To Airline Booking System------------------"
				);
				Console.WriteLine(
					"---------------------------------------------------------------------"
				);
				Console.WriteLine(
					"Enter a 1 for Book seat \nEnter 2 for Exit \nOtherwise please type a Requirement"
				);

				int Status = int.Parse(Console.ReadLine());
				if(Status == 1)
				{
					Console.WriteLine(
						"---------------------------------------------------------------------"
					);
					string[,] seats = Layoutgenerate();

					Console.WriteLine(
						"Please Enter a Seat Number \n W-Window \n M-Middle \n A- Aisle"
					);
					Console.WriteLine(
						"---------------------------------------------------------------------"
					);
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

		private static void Checkseat(string? seatNo, string[,] seats)
		{
			if(array.Length != 0)
			{
				int i = 0;
				while(i < array.Length)
				{
					if(array[i] == seatNo)
					{
						Console.WriteLine("---------------------------------------------------------------------");
                        Console.WriteLine();
						Console.WriteLine("Oops ! Seat is already Booked");
						ShowAvaliableSeat(seats, array);
						break;
					}
					i++;
				}

				if(i == array.Length)
				{
					BookSeat(seatNo);
				}
			}
			else
			{
				BookSeat(seatNo);
			}
		}

		private static void ShowAvaliableSeat(string[,] seats, string[] array)
		{
			Console.WriteLine("Please select the seat from the available seats");
			Console.WriteLine();
			Console.WriteLine("Booked Seats are Marked as X \n Avaliable seats are marked As A");
			Console.WriteLine();
			for(int i = 0; i < 10; i++)
			{
				for(int j = 0; j < 5; j++)
				{
					if(Array.Exists(array, element => element == seats[i, j]))
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
		public static void BookSeat(string seatNo)
		{
			Console.WriteLine();
			Console.Write("Your Seat is Available Now. \nPlease Enter your Name: ");
			string strname = Console.ReadLine();
			Console.WriteLine();
			Console.Write("Please Enter Your Gender (M / W): ");
			string strgender = Console.ReadLine();
			Console.WriteLine();
			Console.Write("Please Enter your Age: ");
			int nage = int.Parse(Console.ReadLine());

			PassengerDetail passengerDetail = new(Name, Gender, Age);
			List<PassengerDetail> passengerDetails = new List<PassengerDetail>();
			passengerDetails.Add(passengerDetail);
			list.Add(seatNo);
			array = list.ToArray();
			Console.WriteLine("---------------------------------------------------------------------");

			Console.WriteLine();
			Console.WriteLine("Your Seat Is Booked ! happy Journey ! Visit Again");
			Console.WriteLine();
			Console.WriteLine("---------------------------------------------------------------------");
		}
	}
}

