using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


    public class gameSet
    {
        public bool[] door1;
        public gameSet()
        {
             
            bool[] door = {false, false, false};
            Random rnd = new Random();
            int num = rnd.Next(3);
            door[num] = true;
            door1 = door;
        }
    }


    public class Game
    {
        public bool win;
        public Game(bool switchDoor)
        { 
            gameSet current = new gameSet();
            Random rnd = new Random();
            int pick = rnd.Next(3); //הבחירה של השחקן

            int reveal = 0;
            if (reveal == pick || current.door1[reveal] == true)
                reveal++;
            if (reveal == pick || current.door1[reveal] == true)
                reveal++;
            if (reveal == pick || current.door1[reveal] == true) Console.WriteLine("error");

            if(switchDoor){pick = 3 - pick - reveal;}
            if (current.door1[pick]) win = true;
            else win = false;
        }

    }


    class Program
    {
    
        static void Main(string[] args)
        {
            int num_games = 1000000;
            int win_switch = 0;
            int win_no_switch = 0;
            for(int i = 0; i < num_games; i++){
                Game gameOne = new Game(false);
                if (gameOne.win) win_no_switch++;
                Game gameTwo = new Game(true);
                if (gameTwo.win) win_switch++;
            }
            Console.WriteLine("wins with switch tactic:"+win_switch);
            Console.WriteLine("wins without switch tactic:"+win_no_switch);


        }
    }
}
