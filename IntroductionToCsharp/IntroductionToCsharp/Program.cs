﻿using IntroductionToCsharp;
using PATA = IntroductionToCsharp.ProjectA.TeamA;
using PATB = IntroductionToCsharp.ProjectA.TeamB;

namespace IntroductionToCsharp
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("this is the first POC!");

            //Console.WriteLine("Min value is :" +int.MinValue);
            //Console.WriteLine("Max value is :" +int.MaxValue);

            //EscapeSequence escapeSequence = new EscapeSequence();
            //escapeSequence.print();

            //Operators operators = new Operators();
            //operators.operations();

            //NullColaesingOperator nullColaesingOperator = new NullColaesingOperator();
            //nullColaesingOperator.nulldemo();

            //DatatypeConversion datatypeConversion = new DatatypeConversion();
            //datatypeConversion.ConversionDemo();

            //ArrayDemo arrayDemo = new ArrayDemo();
            //arrayDemo.arrayDemo();

            //IfElseDemo ifElseDemo = new IfElseDemo();
            //ifElseDemo.ifelsedemo();

            //SwitchCaseDemo switchCaseDemo = new SwitchCaseDemo();
            // switchCaseDemo.SwitchDemo();
            //switchCaseDemo.GotoDemo();

            //LoopDemo loopDemo = new LoopDemo();
            //loopDemo.loopsdemo();

            // MethodDemo.EvenNumbers(30);
            //MethodDemo methodDemo = new MethodDemo();
            //int result = methodDemo.sum(10,20);
            //Console.WriteLine(result);

            //int i = 0;
            //MethodDemo.refvalue(ref i);
            //Console.WriteLine(i);
            //int sum = 0;
            //int product = 0;
            //MethodDemo.calculate(10,20,out sum, out product);
            //Console.WriteLine("sum is {0} and product is {1}",sum,product);

            //int[] arr = new int[5];
            //MethodDemo.paramsarray();
            //MethodDemo.paramsarray(1,2,3,4,5,6,7,8,9,10);

            //fully qualified
            //ProjectA.TeamA.NameSpaceDemo nameSpaceDemo = new ProjectA.TeamA.NameSpaceDemo();
            //nameSpaceDemo.print();

            //PATB.NameSpaceDemo nameSpaceDemo = new PATB.NameSpaceDemo();
            //nameSpaceDemo.print();
            //PATA.NameSpaceDemo nameSpaceDemo1 = new PATA.NameSpaceDemo();
            //nameSpaceDemo1.print();

            //Customer customer = new Customer("Neha","Gohil");
            //customer.PrintFullname();

            //Customer customer1 = new Customer();
            //customer1.PrintFullname();

            //StaticDemo staticDemo = new StaticDemo(5);
            //float areaofcirecle = staticDemo.calculateArea();
            //Console.WriteLine("Area of circle is {0}",areaofcirecle);

            //Employee FTE = new FullTimeEmployee();
            //FullTimeEmployee FTE = new FullTimeEmployee();
            //FTE.firstname = "Neha";
            //FTE.lastname = "Gohil";
            //FTE.yearlysalary = 50000;
            //FTE.PrintFullname();
            //FTE.printsal();

            //PartTimeEmployee PTE = new PartTimeEmployee();
            //PTE.firstname = "Ramesh";
            //PTE.lastname = "Lodha";
            //PTE.hourlyRate = 300;
            //Typecast
            //((Employee)PTE).PrintFullname();
            //PTE.printsal();

            //ConstructorInvocationDemoChild CtorChild = new ConstructorInvocationDemoChild();

            //Virtual Demo - polymorphism

            //EmployeeVirtual[] employees = new EmployeeVirtual[4];
            //employees[0] = new EmployeeVirtual();
            //employees[1] = new FullTimeVirtualEmployee();
            //employees[2] = new PartTimeVirtualEmployee();
            //employees[3] = new TemporaryVirtualEmployee();

            //foreach (var e in employees)
            //{
            //    e.PrintFullName();
            //}

            //MethodOverloadingDemo methodOverloadingDemo = new MethodOverloadingDemo();
            //methodOverloadingDemo.add(10, 20,30);

            //StudentGetterSetterDemo stud = new StudentGetterSetterDemo();
            //stud.SetId(1);
            //stud.SetName("Neha");
            //int id = stud.GetId();
            //string name = stud.GetName();
            //int marks = stud.GetPassMarks();

            //Console.WriteLine("Id is:"+id);
            //Console.WriteLine("Name is :"+name);
            //Console.WriteLine("Pass marks is :"+marks);
            //stud.DisplayStudentDetails();

            //StudentPropertiesDemo stud1 = new StudentPropertiesDemo();
            //stud1.id = 101;
            //stud1.name = "Viraj";
            //Console.WriteLine(stud1.id);
            //Console.WriteLine(stud1.name);
            //Console.WriteLine(stud1.marks);

            //StudentStructDemo studstruct = new StudentStructDemo(1,"Viraj");
            //studstruct.PrintName();

            //object initializer
            //StudentStructDemo studstruct1 = new StudentStructDemo
            //{
            //    Id = 101,
            //    Name = "Babloo"
            //};
            //studstruct1.PrintName();

            //IInterfaceDemo1 interfaceDemo = new InterfaceDemo();
            //interfaceDemo.PrintMessage();
            //interfaceDemo.PrintMessagefromsecondinterface();

            //ExplicitInterfaceDemo demo = new ExplicitInterfaceDemo();
            //((I1)demo).interfaceMethod();
            //((I2)demo).interfaceMethod();

            //AbstractClassDemo absdemo = new derived();
            //absdemo.Print();

            //MultipleClassInterfaceDemo multipleClassInterfaceDemo = new MultipleClassInterfaceDemo();
            //multipleClassInterfaceDemo.AMethod();
            //multipleClassInterfaceDemo.BMethod();

            //basic delegate demo

            //HelloDelegate del = new HelloDelegate(BasicDelegateDemo.Hello);
            //del("Hello Delegate");

            //delegate usage
            //EmployeeDelegateDemo employeeDelegateDemo = new EmployeeDelegateDemo();
            //List<EmployeeDelegateDemo> employeelist = new List<EmployeeDelegateDemo>();
            //employeelist.Add(new EmployeeDelegateDemo() { ID = 101, Name = "Mary", Salary = 8000, Experience = 8 });
            //employeelist.Add(new EmployeeDelegateDemo() { ID = 102, Name = "Bosh", Salary = 5000, Experience = 5 });
            //employeelist.Add(new EmployeeDelegateDemo() { ID = 103, Name = "John", Salary = 2000, Experience = 2 });
            //employeelist.Add(new EmployeeDelegateDemo() { ID = 104, Name = "Rihana", Salary = 4000, Experience = 4 });
            //EmployeeDelegateDemo.EmployeePromotion(employeelist);

            //Exception Handeling demo

            //StreamReader sw = null;
            //try
            //{
            //    sw = new StreamReader(@"C:\sample\Data.txt");
            //    Console.WriteLine(sw.ReadToEnd());
            //}
            //catch(FileNotFoundException ex)
            //{
            //    Console.WriteLine("File not found");

            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    sw.Close();
            //    Console.WriteLine("Finally executed");
            //}

            //Inner Exception demo
            try
            { 
                try
                {
                    int num1, num2, result;
                    Console.WriteLine("Enter first number");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    result = num1 / num2;
                    Console.WriteLine("Result is = {0}", result);
                }
                catch(Exception ex)
                {
                    string filepath = @"C:\sample\log1.txt";
                    if(File.Exists(filepath))
                    {
                        StreamWriter sw = new StreamWriter(filepath);
                        sw.Write(ex.GetType().Name);
                        Console.WriteLine();
                        sw.Write(ex.Message);
                        sw.Close();
                        Console.WriteLine("There is a problem, please try later....");

                    }
                    else
                    {
                        throw new FileNotFoundException(filepath +" is not present",ex);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Current Exception is = {0} ", ex.GetType().Name);
                Console.WriteLine("Inner Exception is = {0} ", ex.InnerException.GetType().Name);
            }
            

        }
    }
}