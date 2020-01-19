using System;

namespace Property2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(Car.EGasType.Disel, 1000000);

            myCar.Price = 2000;
        }
    }

    class Car
    {
        private int mPrice = 500000;
        private int mGas;
        public enum EGasType
        {
            Gasoline,
            Disel
        }

        public EGasType GasType;
        public Car(EGasType gasType, int price)
        {
            GasType = gasType;
            Price = price;
        }

        public int Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                if(value >= 500000)
                {
                    mPrice = value;
                }
            }
        }
    }
}
