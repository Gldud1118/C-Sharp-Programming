using System;

namespace Property
{
    class Program
    {
        static void Main(string[] args)
        {
            //프로퍼티란 겟터와 셋터를 손쉽게 만들 수 있는 방법
            Car myCar = new Car(Car.EGasType.Disel, 100000);
            myCar.FillUp(50.0f);

            //float remainingFuel = myCar.mGas; 보호 수준 때문에 'Car.mGas'에 액세스할 수 없습니다.

            int newPrice;
            int.TryParse(Console.ReadLine(), out newPrice);
            if(newPrice > 500000)
            {
                //myCar.mPrice = newPrice; 컴파일 오류
            }
        }
    }

    class Car
    {
        private float mGas;

        private int mPrice = 50000;
        public enum EGasType
        {
            Gasoline,
            Disel
        }

        public EGasType GasType;

        public Car(EGasType gasType, int price)
        {
            GasType = gasType;
            mPrice = price;

        }

        public void FillUp(float gas)
        {
            mGas += mGas;
        }
    }
}
