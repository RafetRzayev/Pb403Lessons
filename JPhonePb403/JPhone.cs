using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPhonePb403;

public abstract class JPhone
{
    protected JPhone(string name)
    {
        Name = name;
    }
   
    public int ValidCallCount { get; protected set; }
    public int Index { get; protected set; }
    public string Name { get; private set; }
    public int Memory { get; protected set; }
    protected string[] Accounts { get; set; }
    public string CurrentAccount { get;  protected set; }
    public abstract void Call(string number);

    public void AddAccount(string accountName)
    {
        if (Index >= Accounts.Length)
        {
            Console.WriteLine("You cannot add more accounts, limit is reached");

            return;
        }

        Accounts[Index++] = accountName;
        Console.WriteLine($"Account ’{accountName}’ was added");
    }

    public void SetCurrentAccount(string accountName)
    {
        if (!Accounts.Contains(accountName))
        {
            Console.WriteLine("Account not found");

            return;
        }

        CurrentAccount = accountName;
    }

    public void PrintAllAccounts()
    {
        foreach (var item in Accounts)
        {
            if (item == null) continue;

            Console.WriteLine(item);
        }
    }

    public void PrintInfo()
    {
        Console.WriteLine($"JPhone is called ’{Name}’, " +
            $"it has {Memory}GB of memory and {Index} " +
            $"user accounts. Valid calss :{ValidCallCount}" +
            $"Current account {CurrentAccount}");
    }
}
