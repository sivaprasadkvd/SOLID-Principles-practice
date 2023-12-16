using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//interface segregation : states that a class should not be forced to implement interfaces that it does not use

//it is better to have multiple smaller interfaces than larger interfaces


namespace solid_principles_practice
{

    interface Icar
    {
        void Drive();

        void Fly();
    }

    internal class FlyingCar : Icar
    {
        public void Drive()
        {
            Console.WriteLine("Drive car");
        }

        public void Fly()
        {
            Console.WriteLine(" Fly car");

        }
    }

    public class Car : Icar
    {
        public void Drive()
        {
            Console.WriteLine("Drive car");
        }

        public void Fly()
        {
            throw new NotImplementedException();

        }
    }


    //=================================================================================================

    /*
    interface IDrive
    {
        void Drive();
    }

    interface IFly
    {
        void Fly();
    }


    internal class FlyingCar : IDrive , IFly
    {
        public void Drive()
        {
            Console.WriteLine("Drive car");
        }

        public void Fly()
        {
            Console.WriteLine(" Fly car");

        }
    }

    public class Car : IDrive
    {
        public void Drive()
        {
            Console.WriteLine("Drive car");
        }

        
    }

    */

}
