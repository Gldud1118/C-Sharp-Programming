using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClass
{
    public partial class Robot
    {
        //이미 Robot.LeftArm.cs에서 생성자가 정의되어 있어서 재정의는 불가

        public void Nuke()
        {
            Console.WriteLine($"{Name} : Nuclear launch detected");
        }
    }
}
