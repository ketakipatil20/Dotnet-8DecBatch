using System;

namespace Assignment_5_Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            Player[] India = new Player[3]
            {
                new Player("Virat", 50),
                new Player("Smith", 25),
                new Player("Watson", 10),
            };





            Team playerList = new Team(India);
            foreach (Player p in playerList)



                Console.WriteLine(p.pName + " " + p.run_scored);

        }

    }
}   

