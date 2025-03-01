using System.Runtime;

namespace JPhonePb403
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StandartJPhone standartJPhone = new StandartJPhone("hgjk");
            //standartJPhone.AddAccount("Tina");
            //standartJPhone.Call("441234");
            //standartJPhone.PrintInfo();
            //standartJPhone.AddAccount("Kevin");
            //standartJPhone.PrintAllAccounts();

            var advancedPhone = new AdvancedJPhone("GH");
            advancedPhone.Call("4678273");
            advancedPhone.Call("4678273");
            advancedPhone.AddAccount("Tina1");
            advancedPhone.AddAccount("Tina2");
            advancedPhone.AddAccount("Tina3");
            advancedPhone.AddAccount("Tina4");
            advancedPhone.AddAccount("Tina5");
            advancedPhone.AddAccount("Tina6");
            advancedPhone.SetCurrentAccount("ewtgf");
            advancedPhone.SetCurrentAccount("Tina1");
            advancedPhone.PrintInfo();
            advancedPhone.PrintAllAccounts();

            A();
        }
        static void A(params string[] a)
        {
            
        }
        public int MyProperty { protected get; set; }
    }
}
