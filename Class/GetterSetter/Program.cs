using System;

namespace GetterSetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(Car.EGasType.Gasoline, 600000);

            int newPrice;
            int.TryParse(Console.ReadLine(), out newPrice);

            myCar.SetPrice(newPrice);

            float remainingFuel = myCar.GetGas();
            Console.WriteLine($"Remaining fuel : {remainingFuel}L");

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
            SetPrice(price);
        }

        public void SetPrice(int price)
        {
            if(price >= 500000)
            {
                mPrice = price;
            }
        }

        public int GetPrice()
        {
            return mPrice;
        }

        public float GetGas()
        {
            return mGas;
        }
    }
}
