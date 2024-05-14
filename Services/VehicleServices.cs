using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Won7L11.Models;

namespace Won7L11.Services
{
    class VehicleServices
    {
        private double curentFuelInVehicle;
        private double maxFuelInVehicle;
        private CombustibleType combustibleType;
        public Vehicles vehicles;

        public VehicleServices(Vehicles vehicles, double curentFuelInVehicle, double maxFuelInVehicle, CombustibleType combustibleType)
        {
            this.vehicles = vehicles;
            this.curentFuelInVehicle = curentFuelInVehicle;
            this.maxFuelInVehicle = maxFuelInVehicle;
            this.combustibleType = combustibleType;
        }

        public string PresentTheVehicle()
        {
            return $"The vehicle {vehicles.Model} with the following Id {vehicles.Id} is using {combustibleType} and has a tank of {maxFuelInVehicle} liters and is filled with {curentFuelInVehicle} liters.";
        }

        public virtual void Loading (CombustibleType combustible, double loadingFuel)
        {
            if (combustibleType != combustible)
            {
                throw new ArgumentException("The combustible type is different.");
            }

            if (loadingFuel + curentFuelInVehicle <= maxFuelInVehicle)
            {
                curentFuelInVehicle += loadingFuel;
            }
            else
            {
                throw new ArgumentException("The loading fuel must be smaller than the max fuel.");
            }
        }

        public class Gasoline(int id, string model, double curentFuelInVehicle, double maxFuelInVehicle, CombustibleType combustibleType) : VehicleServices(new Vehicles { Id = id, Model = model}, curentFuelInVehicle, maxFuelInVehicle, combustibleType)
        {
            public override void Loading (CombustibleType combustible, double loadingFuel)
            {
                base.Loading(combustible, loadingFuel);
            }
        }

        public class Diesel(int id, string model, double curentFuelInVehicle, double maxFuelInVehicle, CombustibleType combustibleType) : VehicleServices(new Vehicles { Id = id, Model = model }, curentFuelInVehicle, maxFuelInVehicle, combustibleType)
        {
            public override void Loading(CombustibleType combustible, double loadingFuel)
            {
                base.Loading(combustible, loadingFuel);
            }
        }

        public class GPL(int id, string model, double curentFuelInVehicle, double maxFuelInVehicle, CombustibleType combustibleType) : VehicleServices(new Vehicles { Id = id, Model = model }, curentFuelInVehicle, maxFuelInVehicle, combustibleType)
        {
            public override void Loading(CombustibleType combustible, double loadingFuel)
            {
                base.Loading(combustible, loadingFuel);
            }
        }

        public class Hybrid(int id, string model, double curentFuelInVehicle, double maxFuelInVehicle, CombustibleType combustibleType) : VehicleServices(new Vehicles { Id = id, Model = model }, curentFuelInVehicle, maxFuelInVehicle, combustibleType)
        {
            public override void Loading(CombustibleType combustible, double loadingFuel)
            {
                base.Loading(combustible, loadingFuel);
            }
        }

    }
}
