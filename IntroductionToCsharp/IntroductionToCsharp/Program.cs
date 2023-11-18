using IntroductionToCsharp;
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

            MethodOverloadingDemo methodOverloadingDemo = new MethodOverloadingDemo();
            methodOverloadingDemo.add(10, 20,30);
        }
    }
}