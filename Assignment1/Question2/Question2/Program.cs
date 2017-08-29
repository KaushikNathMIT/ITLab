using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2 {
	class Program {
		static void Main(string[] args) {
			Bus bus = new Bus();
			bus.speedHandler += new CustomEventHandler(onChangedSpeed);
			bus.fuelHandler += new CustomEventHandler(onChangedFuel);
			bus.nopHandler += new CustomEventHandler(onChangedNOP);
			bus.Speed = 10;
			bus.Speed = 100;
			bus.Speed = 20;
			bus.Speed = 90;
			bus.Fuel = 20;
			bus.Fuel = 4;
			bus.NumberOfPassengers = 10;
			bus.NumberOfPassengers = 100;
			Console.ReadLine();
		}

		private static void onChangedNOP(object source, EventArgs e) {
			Console.WriteLine("Check Passengers");
		}

		private static void onChangedFuel(object source, EventArgs e) {
			Console.WriteLine("Check Fuel");
		}

		private static void onChangedSpeed(object source, EventArgs e) {
			Console.WriteLine("Check Speed");
		}
	}
}
