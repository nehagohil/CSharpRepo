using IntroductionToCsharp;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using PATA = IntroductionToCsharp.ProjectA.TeamA;
using PATB = IntroductionToCsharp.ProjectA.TeamB;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace IntroductionToCsharp
{
    public delegate void sumOfNumbersCallback(int SumOfNumbers);
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
            //try
            //{ 
            //    try
            //    {
            //        int num1, num2, result;
            //        Console.WriteLine("Enter first number");
            //        num1 = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Enter second number");
            //        num2 = Convert.ToInt32(Console.ReadLine());
            //        result = num1 / num2;
            //        Console.WriteLine("Result is = {0}", result);
            //    }
            //    catch(Exception ex)
            //    {
            //        string filepath = @"C:\sample\log1.txt";
            //        if(File.Exists(filepath))
            //        {
            //            StreamWriter sw = new StreamWriter(filepath);
            //            sw.Write(ex.GetType().Name);
            //            Console.WriteLine();
            //            sw.Write(ex.Message);
            //            sw.Close();
            //            Console.WriteLine("There is a problem, please try later....");

            //        }
            //        else
            //        {
            //            throw new FileNotFoundException(filepath +" is not present",ex);
            //        }
            //    }
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("Current Exception is = {0} ", ex.GetType().Name);
            //    if(ex.InnerException != null)
            //    {
            //        Console.WriteLine("Inner Exception is = {0} ", ex.InnerException.GetType().Name);
            //    }

            //}

            // custom exception Exception demo
            //try
            //{
            //    throw new UserAlreadyLoggedInException("User is logged in - no duplicate session allowed");
            //}
            //catch(UserAlreadyLoggedInException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Preventing exception handling abuse

            //Console.WriteLine("Enter numerator");
            //int numerator;
            //bool IsValidNumerator = Int32.TryParse(Console.ReadLine(), out numerator);
            //if(IsValidNumerator)
            //{
            //    Console.WriteLine("Enter denominator");
            //    int denominator;
            //    bool IsValiddenominator = Int32.TryParse(Console.ReadLine(), out denominator);

            //    if(IsValiddenominator && denominator != 0)
            //    {
            //        int result = numerator / denominator;
            //        Console.WriteLine("Result = {0}",result);
            //    }
            //    else
            //    {
            //        if(denominator == 0)
            //        {
            //            Console.WriteLine("denominator can't be zero");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Denominator should be a valid number between {0} - {1}", Int32.MinValue,Int32.MaxValue);
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Numerator should be a valid number between {0} - {1}", Int32.MinValue, Int32.MaxValue);
            //}

            //Enum demo

            //CustomerEnumDemo[] customerEnumDemo = new CustomerEnumDemo[3];

            //customerEnumDemo[0] = new CustomerEnumDemo
            //{
            //    Name = "Neha",
            //    Gender = Gender.female
            //};
            //customerEnumDemo[1] = new CustomerEnumDemo
            //{
            //    Name = "Rocky",
            //    Gender = Gender.male
            //};
            //customerEnumDemo[2] = new CustomerEnumDemo
            //{
            //    Name = "Sam",
            //    Gender = Gender.unknown
            //};
            //foreach (var item in customerEnumDemo)
            //{
            //    Console.WriteLine("Name = {0} and Gender = {1}", item.Name, CustomerEnumDemo.GetGender(item.Gender));
            //}

            //Enum POC
            //int[] genderstr = (int[])Enum.GetValues(typeof(Genderpoc));
            //foreach (var str in genderstr)
            //{
            //    Console.WriteLine(str);
            //}

            //string[] genderstr1 = (string[])Enum.GetNames(typeof(Genderpoc));
            //foreach (var str1 in genderstr1)
            //{
            //    Console.WriteLine(str1);
            //}

            //reflection demo

            //Type T = Type.GetType("IntroductionToCsharp.CustomerRefelction");
            //Console.WriteLine("Full name = {0}", T.FullName);
            //Console.WriteLine("Name is = {0}", T.Name);
            //Console.WriteLine("Namespace is = {0}", T.Namespace);

            //PropertyInfo[] properties = T.GetProperties();
            //Console.WriteLine("Properties in customer");
            //foreach (var property in properties)
            //{
            //    Console.WriteLine(property.Name);
            //}

            //MethodInfo[] methods = T.GetMethods();
            //Console.WriteLine("Methods in customer");
            //foreach (var method in methods)
            //{
            //    Console.WriteLine(method.Name);
            //}

            //late binding demo for reflection
            //Assembly executingassembly = Assembly.GetExecutingAssembly();
            //Type customerType = executingassembly.GetType("IntroductionToCsharp.Customer");
            //object customerinstance = Activator.CreateInstance(customerType);
            //MethodInfo printFullNameMethod = customerType.GetMethod("PrintFullname");
            //string[] parameters = new string[2];
            //parameters[0] = "Neha";
            //parameters[1] = "Gohil";

            //string fullname = (string)printFullNameMethod.Invoke(customerinstance, parameters);
            //Console.WriteLine("Full name = {0}", fullname);

            //bool IsEqual = Calculator.AreEqual<string>("Shivam", "Shivam");
            //if(IsEqual)
            //{
            //    Console.WriteLine("Equal");
            //}
            //else
            //{
            //    Console.WriteLine("Not Equal");
            //}

            //override ToString method

            //CustomerToString customerToString = new CustomerToString();
            //customerToString.Firstname = "Viru";
            //customerToString.Lastname = "Gohil";
            //Console.WriteLine(Convert.ToString(customerToString));

            // override equal method 
            //CustomerToString c1 = new CustomerToString();
            //c1.Firstname = "Rema";
            //c1.Lastname = "dey";

            //CustomerToString c2 = new CustomerToString();
            //c2.Firstname = "Rihana";
            //c2.Lastname = "dey";

            //Console.WriteLine(c1.Equals(c2));

            // Difference between Convert ToString and ToString
            //CustomerToStringDiff c1 = null;
            //string str = Convert.ToString(c1);
            //Console.WriteLine(str);

            //Difference between String and StringBuilder

            //string
            //string userstring = "C# ";
            //userstring += "Is ";
            //userstring += "a ";
            //userstring += "good ";
            //userstring += "Programming ";
            //userstring += "Language ";
            //Console.WriteLine(userstring);

            //stringBuilder
            //StringBuilder userstring = new StringBuilder("C# ");
            //userstring.Append("Is ");
            //userstring.Append("a ");
            //userstring.Append("good ");
            //userstring.Append("Programming ");
            //userstring.Append("Language ");
            //Console.WriteLine(userstring);

            //partial class demo

            //CustomerPartialClass c2 = new CustomerPartialClass();
            //c2.Firstname = "Neha";
            //c2.Lastname = "Gohil";
            //string fullname1 = c2.GetFullName();
            //Console.WriteLine(fullname1);

            //PartialCustomer c1 = new PartialCustomer();
            //c1.Firstname = "Neha";
            //c1.Lastname = "Gohil";
            //string fullname = c1.GetFullName();
            //Console.WriteLine(fullname);

            //partial method demo
            //PartialMethodClass1 PMC = new PartialMethodClass1();
            //PMC.PrintMessage();

            //CompanyIndexer companyIndexer = new CompanyIndexer();
            //Console.WriteLine("Employee name with id 2 is :" + companyIndexer[2]);
            //Console.WriteLine("Employee name with id 3 is :" + companyIndexer[3]);
            //Console.WriteLine("Employee name with id 4 is :" + companyIndexer[4]);

            //Console.WriteLine("After changing the names");
            //companyIndexer[2] = "Neha";
            //companyIndexer[3] = "Shivam";
            //Console.WriteLine("Employee name with id 2 is :" + companyIndexer[2]);
            //Console.WriteLine("Employee name with id 3 is :" + companyIndexer[3]);

            //CompanyIndexer companyIndexer = new CompanyIndexer();
            //Console.WriteLine("Before update");
            //Console.WriteLine("Total male employees "+ companyIndexer["male"]);
            //Console.WriteLine("Total male employees " + companyIndexer["female"]);
            //companyIndexer["male"] = "female";
            //Console.WriteLine("After update");
            //Console.WriteLine("Total male employees " + companyIndexer["male"]);
            //Console.WriteLine("Total male employees " + companyIndexer["female"]);

            //Program.addNumbers(10,20, new int[] {10,20});
            //Program.Test(50,c:150);
            // Program.addNumbers(10, 20, new int[] { 10, 20 });
            // Program.addNumbers(10, 20);

            //Customr cust1 = new Customr()
            //{
            //    Id = 109,
            //    Name = "ARoma",
            //    salary = 7000
            //};
            //Customr cust2 = new Customr()
            //{
            //    Id = 102,
            //    Name = "CRima",
            //    salary = 6000
            //};
            //Customr cust3 = new Customr()
            //{
            //    Id = 103,
            //    Name = "BRihana",
            //    salary = 9000
            //};

            //List<Customr> customer = new List<Customr>(2);
            //customer.Add(cust1);
            //customer.Add(cust2);
            //customer.Add(cust3);
            //Console.WriteLine("Is salary is greater than 1000 ? "+customer.TrueForAll(x => x.salary > 1000));

            ////customer.Sort((x, y) => x.Id.CompareTo(y.Id));
            ////Comparison<Customr> customerComparer = new Comparison<Customr>(SortByName.CompareCustomer);
            ////customer.Sort(customerComparer);
            //Console.WriteLine("After sorting.....");
            //foreach (var c in customer)
            //{
            //    Console.WriteLine("Id = {0} Name = {1} Salary = {2}", c.Id, c.Name, c.salary);
            //}

            //Console.WriteLine("Before sorting.....");
            //foreach (var c in customer)
            //{
            //    Console.WriteLine("Id = {0} Name = {1} Salary = {2}", c.Id, c.Name, c.salary);
            //}
            //customer.Sort();
            //customer.Reverse();
            //Console.WriteLine("After sorting.....");
            //foreach (var c in customer)
            //{
            //    Console.WriteLine("Id = {0} Name = {1} Salary = {2}", c.Id, c.Name, c.salary);
            //}

            //SortByName sortByName = new SortByName();
            //customer.Sort(sortByName);
            //Console.WriteLine("After sorting.....");
            //foreach (var c in customer)
            //{
            //    Console.WriteLine("Id = {0} Name = {1} Salary = {2}", c.Id, c.Name, c.salary);
            //}

            //Dictionary<int, Customr> customerDictionary = new Dictionary<int, Customr>();
            //customerDictionary.Add(cust1.Id, cust1);
            //customerDictionary.Add(cust2.Id, cust2);
            //customerDictionary.Add(cust3.Id, cust3);

            //Customr[] customer = new Customr[3];
            //customer[0] = cust1;
            //customer[1] = cust2;
            //customer[2] = cust3;

            //List<Customr> customer = new List<Customr>(2);
            //customer.Add(cust1);
            //customer.Add(cust2);
            //customer.Add(cust3);

            //int index = customer.FindLastIndex(2, cust => cust.salary > 5000);
            //Console.WriteLine(index);

            //int index = customer.FindIndex(2,cust => cust.salary > 5000);
            //Console.WriteLine(index);

            //List<Customr> cust = customer.FindAll(cust => cust.salary > 5000);
            //foreach (var c in cust)
            //{
            //    Console.WriteLine("Id = {0} Name = {1} Salary = {2}", c.Id, c.Name, c.salary);
            //}

            //Customr c = customer.FindLast(cust => cust.salary > 5000);
            //Console.WriteLine("Id = {0} Name = {1} Salary = {2}", c.Id, c.Name, c.salary);

            //Customr c = customer.Find(cust => cust.salary > 5000);
            //Console.WriteLine("Id = {0} Name = {1} Salary = {2}", c.Id, c.Name, c.salary);

            //if (customer.Exists(cust => cust.Name.StartsWith("P")))
            //{
            //    Console.WriteLine("object does exists...");
            //}
            //else
            //{
            //    Console.WriteLine("object does not exists...");
            //}
            // customer.Insert(0, cust2);

            //Console.WriteLine(customer.IndexOf(cust2));
            //if (customer.Contains(cust3))
            //{
            //    Console.WriteLine("object does exists...");
            //}
            //else
            //{
            //    Console.WriteLine("object does not exists...");
            //}

            //foreach (Customr c in customer)
            //{
            //    Console.WriteLine(c.Id);
            //}

            // Dictionary<int, Customr> dict = customer.ToDictionary(cust => cust.Id, cust => cust);

            //foreach (KeyValuePair<int,Customr> kvp in dict)
            //{
            //    Console.WriteLine("Key is : "+kvp.Key);
            //    Customr cust = kvp.Value;
            //    Console.WriteLine("Id is = "+ cust.Id);
            //    Console.WriteLine("Name is = " + cust.Name);
            //    Console.WriteLine("Salary is = " + cust.salary);
            //}


            //Console.WriteLine("The Count of customer is = " +customerDictionary.Count(kvp => kvp.Value.salary > 6000));

            //Customr cust;
            //if(customerDictionary.TryGetValue(104, out cust))
            //{
            //    Console.WriteLine("Id = {0} Name = {1} Salary = {2}", cust.Id, cust.Name, cust.salary);
            //}
            //else
            //{
            //    Console.WriteLine("This key is not exists");
            //}

            //Customr customr102 = customerDictionary[102];
            //Console.WriteLine("Id = {0} Name = {1} Salary = {2}", customr102.Id,customr102.Name,customr102.salary);
            //foreach(KeyValuePair<int,Customr> custkeyvaluedictionary in customerDictionary)
            //{
            //    Console.WriteLine("Key = {0}", custkeyvaluedictionary.Key);
            //   Customr cust = custkeyvaluedictionary.Value;
            //    Console.WriteLine("Id = {0}",cust.Id);
            //    Console.WriteLine("Name = {0}", cust.Name);
            //    Console.WriteLine("Salary = {0}", cust.salary);
            //}
            //foreach(int key in customerDictionary.Keys)
            //{
            //    Console.WriteLine(key);
            //}
            //foreach(Customr cust in customerDictionary.Values)
            //{
            //    Console.WriteLine("Id = {0} Name = {1} Salary = {2}", cust.Id, cust.Name, cust.salary);
            //}

            //customerr cust1 = new customerr()
            //{
            //    Id = 101,
            //    Name = "Roma",
            //    salary = 5000,
            //    Type = "Retail"
            //};
            //customerr cust2 = new customerr()
            //{
            //    Id = 102,
            //    Name = "Rima",
            //    salary = 6000,
            //    Type = "Retail"
            //};
            //customerr cust3 = new customerr()
            //{
            //    Id = 103,
            //    Name = "Rihana",
            //    salary = 7000,
            //    Type = "Retail"
            //};
            //customerr cust4 = new customerr()
            //{
            //    Id = 104,
            //    Name = "Anil",
            //    salary = 9000,
            //    Type = "Corporate"
            //};
            //customerr cust5 = new customerr()
            //{
            //    Id = 105,
            //    Name = "Sunil",
            //    salary = 12000,
            //    Type = "Corporate"
            //};

            //List<customerr> listcust = new List<customerr>();
            //listcust.Add(cust1);
            //listcust.Add(cust2);
            //listcust.Add(cust3);

            //List<customerr> listcorporatecust = new List<customerr>();
            //listcorporatecust.Add(cust4);
            //listcorporatecust.Add(cust5);

            //listcust.InsertRange(3, listcorporatecust);
            //foreach (customerr c in listcust)
            //{
            //    Console.WriteLine("Id = {0} Name = {1} Salary = {2} Type = {3}", c.Id, c.Name, c.salary, c.Type);
            //}

            //List<customerr> listcust1= listcust.GetRange(3, 2);
            //foreach (customerr c in listcust)
            //{
            //    Console.WriteLine("Id = {0} Name = {1} Salary = {2} Type = {3}", c.Id, c.Name, c.salary, c.Type);
            //}

            //listcust.AddRange(listcorporatecust);

            //foreach (customerr c in listcust)
            //{
            //    Console.WriteLine("Id = {0} Name = {1} Salary = {2} Type = {3}", c.Id, c.Name, c.salary, c.Type);
            //}

            //List<int> numbers = new List<int> {1,4,8,10,2,6,3,5,7,9 };
            //Console.WriteLine("before sorting..");
            //foreach (int i  in numbers)
            //{
            //    Console.WriteLine(i);
            //}
            //numbers.Sort();
            //Console.WriteLine("After sorting..");
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}
            //numbers.Reverse();
            //Console.WriteLine("After sorting..");
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //Country country1 = new Country() {Code = "IND", Name = "INDIA", Capital ="Delhi" };
            //Country country2 = new Country() { Code = "AUS", Name = "AUSTRALIA", Capital = "Canberra" };
            //Country country3 = new Country() { Code = "USA", Name = "UNITED STATES", Capital = "WASHINGTON D.C" };
            //Country country4 = new Country() { Code = "GBR", Name = "UNITED KINGDOM", Capital = "London" };
            //Country country5 = new Country() { Code = "CAN", Name = "CANADA", Capital = "OTTWA" };

            //List<Country> countries = new List<Country>();
            //countries.Add(country1);
            //countries.Add(country2);
            //countries.Add(country3);
            //countries.Add(country4);
            //countries.Add(country5);

            //Dictionary<string, Country> countrydict = new Dictionary<string, Country>();
            //countrydict.Add(country1.Code, country1);
            //countrydict.Add(country2.Code, country2);
            //countrydict.Add(country3.Code, country3);
            //countrydict.Add(country4.Code, country4);
            //countrydict.Add(country5.Code, country5);

            //string userchoice = string.Empty;
            //do
            //{
            //    Console.WriteLine("Please enter country code");
            //    string strcountrycode = Console.ReadLine().ToUpper();
            //    // Country resultcountry = countries.Find(c => c.Code == strcountrycode);
            //    Country resultcountry = countrydict.ContainsKey(strcountrycode) ? countrydict[strcountrycode] : null;
            //    if (resultcountry == null)
            //    {
            //        Console.WriteLine("Country code not valid");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Name = {0} , Capital = {1} ", resultcountry.Name, resultcountry.Capital);
            //    }
            //    do
            //    {
            //        Console.WriteLine("Do you want to continue ? YES/NO");
            //        userchoice = Console.ReadLine().ToUpper();
            //    } while (userchoice != "NO" && userchoice != "YES");
            //} while (userchoice == "YES");

            //CustomerQueue cq1 = new CustomerQueue { Id = 1, Name = "Mahesh", Gender = "male" };
            //CustomerQueue cq2 = new CustomerQueue { Id = 2, Name = "Suresh", Gender = "male" };
            //CustomerQueue cq3 = new CustomerQueue { Id = 3, Name = "Manali", Gender = "female" };
            //CustomerQueue cq4 = new CustomerQueue { Id = 4, Name = "mohali", Gender = "female" };

            //Stack<CustomerQueue> customerStack = new Stack<CustomerQueue>();
            //customerStack.Push(cq1);
            //customerStack.Push(cq2);
            //customerStack.Push(cq3);
            //customerStack.Push(cq4);

            //CustomerQueue c1 = customerStack.Peek();
            //Console.WriteLine(c1.Id + " - " + c1.Name);
            //Console.WriteLine("Total items in the queue" + customerStack.Count);

            //CustomerQueue c1 = customerStack.Pop();
            //Console.WriteLine(c1.Id + " - " + c1.Name);
            //Console.WriteLine("Total items in the queue" + customerStack.Count);

            //CustomerQueue c2 = customerStack.Pop();
            //Console.WriteLine(c2.Id + " - " + c2.Name);
            //Console.WriteLine("Total items in the queue" + customerStack.Count);

            //CustomerQueue c3 = customerStack.Pop();
            //Console.WriteLine(c3.Id + " - " + c3.Name);
            //Console.WriteLine("Total items in the queue" + customerStack.Count);

            //CustomerQueue c4 = customerStack.Pop();
            //Console.WriteLine(c4.Id + " - " + c4.Name);
            //Console.WriteLine("Total items in the queue" + customerStack.Count);

            //Queue<CustomerQueue> customerQueues = new Queue<CustomerQueue>();
            //customerQueues.Enqueue(cq1);
            //customerQueues.Enqueue(cq2);
            //customerQueues.Enqueue(cq3);
            //customerQueues.Enqueue(cq4);

            //if(customerQueues.Contains(cq1))
            //{
            //    Console.WriteLine("cq1 object exists");
            //}
            //else
            //{
            //    Console.WriteLine("cq1 object doesn't exists");
            //}

            //CustomerQueue cq = customerQueues.Peek();
            //Console.WriteLine(cq.Id + " - " + cq.Name);
            //Console.WriteLine("Total items in the queue" + customerQueues.Count);

            //CustomerQueue c1 = customerQueues.Dequeue();
            //Console.WriteLine(c1.Id + " - " +c1.Name);
            //Console.WriteLine("Total items in the queue" + customerQueues.Count);

            //CustomerQueue c2 = customerQueues.Dequeue();
            //Console.WriteLine(c2.Id + " - " + c2.Name);
            //Console.WriteLine("Total items in the queue" + customerQueues.Count);

            //CustomerQueue c3 = customerQueues.Dequeue();
            //Console.WriteLine(c3.Id + " - " + c3.Name);
            //Console.WriteLine("Total items in the queue" + customerQueues.Count);

            //CustomerQueue c4 = customerQueues.Dequeue();
            //Console.WriteLine(c4.Id + " - " + c4.Name);
            //Console.WriteLine("Total items in the queue" + customerQueues.Count);

            Console.WriteLine("Please enter the target number");
            int target = Convert.ToInt32(Console.ReadLine());
            sumOfNumbersCallback callback = new sumOfNumbersCallback(PrintSumOfNumbers);
            numbers n1 = new numbers(target, callback);
           
           // ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(n1.Printnumbers);
            Thread T1 = new Thread(n1.Printnumbers);
            T1.Start();

        }

        //public static void addNumbers(int fnum, int snum)
        //{
        //    Program.addNumbers(fnum,snum,null);
        //}
        //public static void addNumbers(int fnum, int snum, int[] nums = null)
        //{
        //    int result = fnum + snum;
        //    if(nums != null)
        //    {
        //        foreach (int i in nums)
        //        {
        //            result += i;
        //        }

        //    }
        //    Console.WriteLine("Addition is :" + result);
        //}
        //public static void Test(int a=10, int b=20, int c=30)
        //{
        //    Console.WriteLine("A is " +a);
        //    Console.WriteLine("B is " +b);
        //    Console.WriteLine("C is " +c);
        //}
        //public static void addNumbers(int fnum, int snum, [Optional] int[] nums)
        //{
        //    int result = fnum + snum;
        //    if (nums != null)
        //    {
        //        foreach (int i in nums)
        //        {
        //            result += i;
        //        }

        //    }
        //    Console.WriteLine("Addition is :" + result);
        //}

       public static void PrintSumOfNumbers(int sum)
        {
            Console.WriteLine(" Sum is = "+sum);
        }
    }

    class numbers
    {
        private int _target;
        sumOfNumbersCallback _callbackmethod;
        public numbers(int target, sumOfNumbersCallback callbackmethod)
        {
            this._target = target;
            this._callbackmethod = callbackmethod;
        }
        public void Printnumbers(object target)
        {
            int sum = 0;
                for (int i = 1; i <= _target; i++)
                {
                sum = sum + i;
                }
            if(_callbackmethod != null)
            {
                _callbackmethod(sum);
            }
            
        }
    }

}