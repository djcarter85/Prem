using System;

namespace Prem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var teams = new[]
            {
                new Team { Name = "Liverpool", Won = 32, Drawn = 3 , Lost = 3, For = 85, Against = 33 },
                new Team { Name = "Man City", Won = 26, Drawn = 3 , Lost = 9, For = 102, Against = 35 },
                new Team { Name = "Man United", Won = 18, Drawn = 12 , Lost = 8, For = 66, Against = 36 },
                new Team { Name = "Chelsea", Won = 20, Drawn = 6 , Lost = 12, For = 69, Against = 54 },
                new Team { Name = "Leicester", Won = 18, Drawn = 8 , Lost = 12, For = 67, Against = 41 },
                new Team { Name = "Tottenham", Won = 16, Drawn = 11 , Lost = 11, For = 61, Against = 47 },
                new Team { Name = "Wolves", Won = 14, Drawn = 14 , Lost = 10, For = 56, Against = 48 },
                new Team { Name = "Arsenal", Won = 14, Drawn = 14 , Lost = 10, For = 56, Against = 48 },
                new Team { Name = "Sheff Utd", Won = 14, Drawn = 12 , Lost = 12, For = 39, Against = 39 },
                new Team { Name = "Burnley", Won = 15, Drawn = 9 , Lost = 14, For = 43, Against = 50 },
                new Team { Name = "Southampton", Won = 15, Drawn = 7 , Lost = 16, For = 51, Against = 60 },
                new Team { Name = "Everton", Won = 13, Drawn = 10 , Lost = 15, For = 44, Against = 56 },
                new Team { Name = "Newcastle", Won = 11, Drawn = 11 , Lost = 16, For = 38, Against = 58 },
                new Team { Name = "Crystal Palace", Won = 11, Drawn = 10 , Lost = 17, For = 31, Against = 50 },
                new Team { Name = "Brighton", Won = 9, Drawn = 14 , Lost = 15, For = 39, Against = 54 },
                new Team { Name = "West Ham", Won = 10, Drawn = 9 , Lost = 19, For = 49, Against = 62 },
                new Team { Name = "Aston Villa", Won = 9, Drawn = 8 , Lost = 21, For = 41, Against = 67 },
                new Team { Name = "Bournemouth", Won = 9, Drawn = 7 , Lost = 22, For = 40, Against = 65 },
                new Team { Name = "Watford", Won = 8, Drawn = 10 , Lost = 20, For = 36, Against = 64 },
                new Team { Name = "Norwich", Won = 5, Drawn = 6 , Lost = 27, For = 26, Against = 75 },
            };

            Console.WriteLine("Hello World!");
        }
    }
}
