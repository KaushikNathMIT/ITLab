using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2 {
	public delegate void CustomEventHandler(object source, EventArgs e);
	class Bus {
		float speed, fuel;
		int numberOfPassengers;
		public float Speed {
			get {
				return speed;
			}
			set {
				speed = value;
				onSpeedChanged(speed);
			}
		}

		private void onSpeedChanged(float speed) {
			if (speed > 70) {
				speedHandler(this, new EventArgs());
			}
		}

		public float Fuel {
			get {
				return fuel;
			}
			set {
				fuel = value;
				onFuelChanged(fuel);
			}
		}

		private void onFuelChanged(float fuel) {
			if (fuel < 5) fuelHandler(this, new EventArgs());
		}

		public int NumberOfPassengers {
			get {
				return numberOfPassengers;
			}
			set {
				numberOfPassengers = value;
				onNumberOfPassengersChanged(numberOfPassengers);
			}
		}

		private void onNumberOfPassengersChanged(int numberOfPassengers) {
			if (numberOfPassengers > 60) nopHandler(this, new EventArgs());
		}

		public event CustomEventHandler speedHandler, nopHandler, fuelHandler;

	}
}
