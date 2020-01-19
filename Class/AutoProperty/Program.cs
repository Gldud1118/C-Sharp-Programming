using System;

namespace AutoProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(Car.EGasType.Disel, 100000);

            Console.WriteLine(myCar.GasType);

        }
    }

    class Car
    {
        int Price { get; set; }
        public string Owner { get; set; }
        public float Gas { get; private set; } = 10.0f;

        private float mKillometersTravelled; //이 멤버변수의 기본값은 0.0f 내부에서만 쓰기 때문에 프로퍼티로 만들지 않음
        public enum EGasType
        {
            Gasoline,
            Disel
        }

        public EGasType GasType { get; private set; }

        public Car(EGasType gasType, int price)
        {
            GasType = gasType;
            Price = price;
        }
    }
}
