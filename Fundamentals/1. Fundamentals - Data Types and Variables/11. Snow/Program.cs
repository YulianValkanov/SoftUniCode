using System;

namespace _11._Snow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double BiggestValue = 0;
            int BigestSnowball = 0;
            int BigestSnowballTime = 0;
            int BigestQuality = 0;

            for (int i = 1; i <= n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                int Value = (snowballSnow / snowballTime);

                Double SnowBallValue = Math.Pow(Value, snowballQuality);
          

                if (SnowBallValue>=BiggestValue)
                {
                    BiggestValue = SnowBallValue;
                    BigestSnowball = snowballSnow;
                    BigestSnowballTime = snowballTime;
                    BigestQuality = snowballQuality;
                   
                }
                
                
            }
            Console.WriteLine($"{BigestSnowball} : {BigestSnowballTime} = {BiggestValue} ({BigestQuality})");
        }
    }
}
