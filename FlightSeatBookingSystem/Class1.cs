namespace FlightSeatBookingSystem
{
	public static class Class1
	{
		public static void Main()
		{
			string status = "Book";
			BookFlight(status);

		}

		private static void BookFlight(object book)
		{

			int[][] seats = Array.Empty<int[]>();
			int count = 1;



			for(int i = 0; i < 5; i++)
			{
				for(int j = 0; j < 10; j++)
				{
					char charcount = 'A';
					seats[i][j] = count + charcount;

					charcount++;
				}
				count++;

			}
			Console.WriteLine(seats[0][5]);

			//if(Status == Book)
			//{

			//}
		}


	}
}
