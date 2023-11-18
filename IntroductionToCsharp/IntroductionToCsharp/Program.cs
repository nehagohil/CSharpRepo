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
            int sum = 0;
            int product = 0;
            MethodDemo.calculate(10,20,out sum, out product);
            Console.WriteLine("sum is {0} and product is {1}",sum,product);
        }
    }
}