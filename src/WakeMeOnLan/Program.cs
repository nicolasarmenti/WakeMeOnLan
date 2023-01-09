namespace WakeMeOnLan {
	class Program {
		static void Main(string[] args) {
			string macAddress = "1C-87-2C-D0-CB-1E";

			WOL.WakeOnLan(macAddress);
		}
	}
}