namespace FlightSeatBookingSystem_Task
{
	public  class PassengerDetail
	{
		private object name;
		private object gender;
		private object age;

		public PassengerDetail(object name, object gender, object age)
		{
			this.name = name;
			this.gender = gender;
			this.age = age;
		}

		public string Name { get; set; }
		public string Gender { get; set; }
		public int Age { get; set; }
	}
}