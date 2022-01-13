using System;
namespace basic
{
    public abstract class Calculations
    {
        public abstract void cal(double c, double d);
    }

    public class Add : Calculations
    {
        public override void cal(double c, double d)
        {
            c+=d;
            Console.WriteLine("Result is: {0}",c);
        }
        
    }
    public class Subtract : Calculations
    {
        public override void cal(double c, double d)
        {
            c-=d;
            Console.WriteLine("Result is: {0}",c);
        }
        
    }
    public class Multiply : Calculations
    {
        public override void cal(double c, double d)
        {
             c*=d;
            Console.WriteLine("Result is: {0}",c);
        }
        
    }
    public class Divide : Calculations
    {
        public override void cal(double c, double d)
        {
            c/=d;
            Console.WriteLine("Result is: {0}",c);
        }
        
    }
    public class Test
    {
        public static void Main(string[] args)
        {
            Calculations c;
            Console.WriteLine("Enter two numbers:");
            double one=0;
            double.TryParse(Console.ReadLine(),out one);
            double two=0;
            double.TryParse(Console.ReadLine(),out two);
            Console.WriteLine("Enter your choice 1=ADD, 2=SUBTRACT, 3=MULTIPLY, 4=DIVIDE");
            int choice=Convert.ToInt32(Console.ReadLine());
            
            switch(choice)
            {
                case 1:
                {
                    c=new Add();
                    c.cal(one, two);
                    break;
                }
                case 2:
                {
                    c=new Subtract();
                    c.cal(one, two);
                    break;
                }
                case 3:
                {
                    c=new Multiply();
                    c.cal(one, two);
                    break;
                }
                case 4:
                {
                    c=new Divide();
                    c.cal(one, two);
                    break;
                }
                default:
                {
                    Console.WriteLine("Select appropriate option");
                    break;
                }

            }
            
        }
    }
}
