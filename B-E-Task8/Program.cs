using System;

namespace B_E_Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            IAccount account = new User("tural@mail.az", "T1998l", "Tural Ismayilov");
            if (account.PasswordChecker())
            {
                account.ShowInfo();
            }
            else { Console.WriteLine("Sifreniz yeterli deyil"); }
        }
    }
}
