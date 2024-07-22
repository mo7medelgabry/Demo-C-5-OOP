using Demo_C__5_OOP.Abstraction;
using Demo_C__5_OOP.Casting_Operator_Overloading;
using Demo_C__5_OOP.Operator_Overloading;
using System;
using System.Drawing;

namespace Demo_C__5_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Operator Overloading 
            Complex C1 = new Complex();
            C1.Imag = 5;
            C1.Real = 3;
            Console.WriteLine(C1);
            Complex C2 = new Complex() { Real = 2, Imag = 4 };
            Console.WriteLine(C2);
            Complex C3 = new Complex();
            C3 = C1 + C2; 
            Console.WriteLine(C3);

            Complex C4 = new Complex();
             C4 = C3 - C2;
            Console.WriteLine(C4);

            #endregion Unary Operators 

            #region
            Complex C5 = new Complex();
            C5=default;

            C5 = ++C2; 
            Console.WriteLine(C5);

            C5 = --C2;
            Console.WriteLine(C5);
            #endregion
           
            #region releational operator 
            if ( C1 > C2 )
            {
                Console.WriteLine("C1 is Greater than C2");
            }
            else
            {
                Console.WriteLine(" C2 is Greater than C1");
            }

            #endregion

            #region Caasting operators overloading 
             
            Complex C6 = new Complex();
            C6.Real = 8;
            C6.Imag = 7;
            int X =(int) C6;
            Console.WriteLine(X);
            String S1 =  C6;
            Console.WriteLine(S1);
            #endregion

            #region Castig Operators 
            Employee employee = new Employee()
            { 
                Id = 10,
                Name = "Mohamed ELGabry",
                Password = "password",
                Email = "mo7medelgabry@gmail.com",
                SecurityStamp = Guid.NewGuid(),
            };

            EmployeeViewModel employeeViewModel = new EmployeeViewModel();
            employeeViewModel = (EmployeeViewModel) employee;
            Console.WriteLine(employeeViewModel.FirstName);
            Console.WriteLine(employeeViewModel.LastName);


            #endregion


            #region Abstract  
             Area area = new Area(10,20) ;
            decimal RecArea = area.CalcArea();
            Console.WriteLine(RecArea);
             Console.WriteLine(area.Perimeter);
            Square square = new Square(50);
            Circle circle = new Circle(30);  
            Console.WriteLine(circle.CalcArea());
             
            
            
            #endregion










        }
    }
}
