using System;

namespace Final_Exam_13._12._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string input = Console.ReadLine();


            while (input!="Finish")
            {
                string[] inputArgs = input.Split(" ");

                string comands = inputArgs[0];

                if (comands == "Replace")
                {
                    string currentChar = (inputArgs[1]);
                    string newChar = (inputArgs[2]);

                    message = message.Replace(currentChar, newChar);

                    Console.WriteLine(message);
                }
                else if (comands=="Cut")
                {
                    int startIndex = int.Parse((inputArgs[1]));
                    int endIndex = int.Parse((inputArgs[2]));
                    //true
                    if (startIndex>=0&&startIndex<message.Length&&endIndex>=0&&endIndex<message.Length)
                    {
                        message = message.Remove(startIndex, (endIndex-startIndex+1));
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }

                }
                else if (comands=="Make")
                {
                    string UperLower = inputArgs[1];

                    if (UperLower=="Upper")
                    {
                        message = message.ToUpper();
                    }
                    else if (UperLower=="Lower")
                    {
                        message = message.ToLower();
                    }
                    Console.WriteLine(message);
                }
                else if (comands=="Check")
                {
                    string check = inputArgs[1];
                    //true
                    if (message.Contains(check))
                    {
                        Console.WriteLine($"Message contains {check}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {check}");
                    }
                }
                else if (comands=="Sum")
                {
                    int startIndex = int.Parse((inputArgs[1]));
                    int endIndex = int.Parse((inputArgs[2]));

                    //true
                    if (startIndex >= 0 && startIndex < message.Length && endIndex >= 0 && endIndex < message.Length)
                    {
                        string substractingTexts = message.Substring(startIndex, (endIndex - startIndex + 1));
                        int sumText = 0;
                        for (int i = 0; i < substractingTexts.Length; i++)
                        {
                            sumText += substractingTexts[i];
                        }
                        Console.WriteLine(sumText);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                }





                input = Console.ReadLine();
            }
        }
    }
}
