namespace JPhonePb403;

public class StandartJPhone : JPhone
{
    public StandartJPhone(string name) : base(name)
    {
        Memory = 32;
        Accounts = new string[3];
    }

    public override void Call(string number)
    {
        if (number.Length < 6 || number.Length > 8)
        {
            Console.WriteLine("Invalid phone number, please check the number!");

            return;
        }

        if (!(number.StartsWith("4") || number.StartsWith("6")))
        {
            Console.WriteLine("Invalid phone number, please check the number!");

            return;
        }

        for (int i = 0; i < number.Length; i++)
        {
            if (!char.IsDigit(number[i]))
            {
                Console.WriteLine("Invalid phone number, please check the number!");

                return;
            }
        }

        Console.WriteLine($"Calling to the number {number}");
        ValidCallCount++;
    }
}

public class AdvancedJPhone : JPhone
{
    public AdvancedJPhone(string name) : base(name)
    {
        Memory = 64;
        Accounts = new string[5];
    }

    public override void Call(string number)
    {
        if (number.Length < 6 || number.Length > 9)
        {
            Console.WriteLine("Invalid phone number, please check the number!");

            return;
        }

        if (!(number.StartsWith("4") || number.StartsWith("6")))
        {
            Console.WriteLine("Invalid phone number, please check the number!");

            return;
        }

        for (int i = 0; i < number.Length; i++)
        {
            if (!char.IsDigit(number[i]))
            {
                Console.WriteLine("Invalid phone number, please check the number!");

                return;
            }
        }

        Console.WriteLine($"Calling to the number {number}");
        ValidCallCount++;
    }
}
