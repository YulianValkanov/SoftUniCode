using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {

            double NeedMoney = double.Parse(Console.ReadLine());
            double CurrentMoney = double.Parse(Console.ReadLine());
            int CountSpend = 0;
            int CountSave = 0;
           

            while (CurrentMoney<NeedMoney)
            {
                string Type = Console.ReadLine();
                double Money = double.Parse(Console.ReadLine());
                if(Type== "spend")
                {
                    CountSpend++;
                    if (CurrentMoney<=Money)
                    {
                        CurrentMoney = 0;
                    }
                    else
                    {
                        CurrentMoney -= Money;
                    }
                    if (CountSpend >= 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(CountSpend);
                        break;
                    }
                    

                }
                else if (Type == "save")
                {
                    CountSave++;
                    CurrentMoney += Money;
                }
            }

            if (CurrentMoney >= NeedMoney&&CountSave<=5)
            {
                Console.WriteLine($"You saved the money for {CountSpend+CountSave} days.");
            }
           
        }
    }
}
