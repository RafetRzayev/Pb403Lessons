namespace StoreManagment
{
    internal class Program
    {
        static User[] Users = [new("kenan", "1234", Role.Admin), new("ferid", "1234", Role.Client)];

        static void Main(string[] args)
        {
            var storage = new Storage();
            User user;
            do
            {
                Console.Write("Username:");
                string userName = Console.ReadLine();
                Console.Write("Password:");
                string password = Console.ReadLine();
                user = GetUser(userName, password);
            } while (user.Username == "undefined");

            if (user.Role == Role.Admin)
            {
                Console.WriteLine($"Welcome {user.Username}");
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Choose options:");
                    Console.WriteLine("[0]: show product");
                    Console.WriteLine("[1]: add product");
                    Console.WriteLine("[2]: update product");
                    Console.WriteLine("exit: for exiting programm");
                    Console.WriteLine();

                    string command = Console.ReadLine();

                    switch (command)
                    {
                        case "0":
                            storage.PrintProducts();
                            break;
                        case "1":
                            storage.Add();
                            break;
                        case "2":
                            storage.Update();
                            break;
                        case "exit":
                            return;
                        default:
                            Console.WriteLine("That is not correct command");
                            break;
                    }

                } while (true);

            }
            else
            {
                Console.WriteLine($"Welcome {user.Username}");
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Choose options:");
                    Console.WriteLine("[0]: buy product");
                    Console.WriteLine("exit: for exiting programm");
                    Console.WriteLine();

                    string command = Console.ReadLine();

                    switch (command)
                    {
                        case "0":
                            storage.BuyProduct(user);
                            break;
                        case "exit":
                            return;
                        default:
                            Console.WriteLine("That is not correct command");
                            break;
                    }

                } while (true);
            }
        }

        static User GetUser(string username, string password)
        {
            foreach (var item in Users)
            {
                if (item.Username == username && item.Password == password)
                    return item;
            }

            return default;
        }
    }
}
