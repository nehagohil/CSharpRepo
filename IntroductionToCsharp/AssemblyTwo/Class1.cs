using AssemblyOne;

namespace AssemblyTwo
{
    public class AssemblyTwoClass
    {
        public void test()
        {
            AssemblyOneClass assemblyOneClass = new AssemblyOneClass();
            assemblyOneClass.Print();
        }
       

    }
}