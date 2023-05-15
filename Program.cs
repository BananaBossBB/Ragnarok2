using System;

class Program 
{    
    static void Main(string[] args) 
    {
        int city = int.Parse(Console.ReadLine());
        string[] cityName = new string[city];
        int[] covidLevel = new int[city];
        int[] cityNum = new int[city];

        for(int i = 0;i < city; i++)
        {
            cityNum[i] = i;
            cityName[i] = Console.ReadLine();
            int cityCommu = int.Parse(Console.ReadLine());
            
            for(int l = 0;l <= cityCommu;l++)
            {    
                int cityCommuNum = int.Parse(Console.ReadLine());
                if(cityCommuNum > city)
                {
                    Console.WriteLine("Invalid ID");
                }
                else
                {
                }
            }
        }   
        Console.WriteLine(cityName[0],covidLevel); //test
        Console.WriteLine(cityName[1],covidLevel);
        Console.WriteLine(cityName[2],covidLevel);
    }
}