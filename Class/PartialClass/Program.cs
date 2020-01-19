using System;

namespace PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot("Taekwon V");

            robot.ShootLaserBeam();
            robot.ShootMissiles();
            robot.Nuke();
        }
    }
}
