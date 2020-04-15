using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Здраствуйте  игроки  которые в это будут играть");
            Console.WriteLine("Правила: в игре есть 2 игрока ");
            Console.WriteLine("У каждого игрока есть своя клавиша");
            Console.WriteLine("У игрока andr клавиша 'стрелка вверх' ");
            Console.WriteLine("У игрока NoName клавиша 'space' ");
            Console.WriteLine("Можно играть двоим  после окончание таймера вы должны нажать на свои кнокпи" );
            Console.WriteLine("Кто нажмет первый на свою конпку тот на несет врагу своему -10хр");
            Console.WriteLine("У кого меньше хр тот проигрывает, всего 5 раундов. Продолжить ");

            Console.ReadKey();
            
            // создаю экземпляр класса Player
            Player player_one = new Player("ANDR");
            Player player_two = new Player("NoName");
            
            // устанавливаю ХР
            int count = player_one.health;
            int count_two = player_two.health;

            // циккл с раундами
          
            for (var i = 1; i<= 5; i++)
            {
                //таймер
                for (var j =1; j <=3; j++)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine(j);
                }

                Console.WriteLine("Нажимай");
                // проверка клавиш
                var key = Console.ReadKey().Key;

              if (key == ConsoleKey.Spacebar)
                {
                    count = count - 10;
                    Console.WriteLine("Игрок {0}  первее на нес удар игроку {1} и отнял 10хр ", player_two.name, player_one.name);
                    player_one.health = count;
               }

               else if (key == ConsoleKey.UpArrow)
                {

                    count_two = count_two - 10;
                    Console.WriteLine("Игрок {0}  первее на нес удар игроку {1} и отнял 10хр ", player_one.name, player_two.name);
                    player_two.health = count_two;

                }
              // статистика каждого раунда
                Console.WriteLine("Статистика Round {0} у игрока {1} health: {2}, игоок {3}  health: {4} ",
                    i, player_one.name,  player_one.health, player_two.name, player_two.health);
              
            }

            Console.ReadKey();
        }
    }


    class Player 
    {
        public string name { get; set; }
        public int health { get; set; }

        public Player(string n)
        {
            name = n;
            health = 100;
        }
        public void GetInfo()
        {
            Console.WriteLine("Name {0} Health {1}", name, health);
        }
    }

  
}
