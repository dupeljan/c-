using System;

namespace ConsoleApplication13
{
    class Car
    {
        private readonly int num;
        private const int min = 3;
        private const int max = 5;
        private string title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public Car(int num)
        {
            if ( num < min)
            {
                Console.WriteLine("Val = " + num.ToString() + " is lower than min = " + min.ToString() + ". Set val to min");
            }
            else if (num > min)
            {
                Console.WriteLine("Val = " + num.ToString() + " is upper than max = " + max.ToString() + ". Set val to max");
            }
            else 
                this.num = num; 

        }

        public override string ToString()
        {
            return "Car num " + num.ToString();
        }
    }

    class main
    {
        [STAThread]
        static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                Car x = new Car(i);
                Console.WriteLine(x.ToString());
            }
        }
    }


}