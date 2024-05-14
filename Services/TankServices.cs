using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Won7L11.Models;
using Won7L11.Services;

namespace Won7L11.Services
{
    class TankServices
    {
        private double curentQuantity;
        private double maxQuantity;
        private CombustibleType combustible;

        public TankServices(double curentQuantity,double maxQuantity, CombustibleType combustible)
        {
            this.curentQuantity = curentQuantity;
            this.maxQuantity = maxQuantity;
            this.combustible = combustible;
        }

        public void LoadingTank (double loadedQuantity, CombustibleType combustibleType)
        {
            if (combustible != combustibleType)
            {
                throw new ArgumentException("The combustible type is different.");
            }

            if (loadedQuantity + curentQuantity <= maxQuantity)
            {
                curentQuantity += loadedQuantity;
            }
            else
            {
                throw new ArgumentException("The loaded quatity must be smaller than max quatity.");
            }
        }


        public void LoadingVehicle(double loadingQuantity, VehicleServices vehicles)
        {

            if(curentQuantity < loadingQuantity)
            {
                throw new ArgumentException("The loading quantity is smaller than the current quantity of fuel in the tank. Choose a smaller value.");
            }

            try
            {
                vehicles.Loading(combustible, loadingQuantity);
            }
            catch(Exception e)
            {
                Console.WriteLine("The loading of the car failed." + e.Message);
            }
        }

    }
}
