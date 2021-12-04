using System;

namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            //hello
            //hello2
        
            int playerResult;

            int dragonResult;

            int damage;

            int playerHealth = 100;

            int dragonHealth = 100;

            System.Console.WriteLine("You have encountered a dragon!");

            for (int i = 0; i < 5; i++) // main game
            {
                 System.Console.WriteLine("Press 'Enter' to roll the dice");
                Console.ReadKey();

                Random numberGen = new Random();

                playerResult = numberGen.Next(1,7);

                System.Console.WriteLine("You rolled a " + playerResult);

                System.Console.WriteLine("--------------");
                System.Threading.Thread.Sleep(1000);

                dragonResult = numberGen.Next(1,7);

                 System.Console.WriteLine("Enemy rolled a " + dragonResult); 

                 System.Console.WriteLine("-------------");
                 System.Threading.Thread.Sleep(400);

                 playerResult = PlayerAttack(playerResult);

                 System.Threading.Thread.Sleep(400);

                 dragonResult = DragonAttack(dragonResult);
            }


                  if (playerHealth > dragonHealth) //win function
                {
                    System.Console.WriteLine("Warrior wins!");
                }
                else
                {
                    System.Console.WriteLine("Dragon Wins!");
                }

                int PlayerAttack(int playerResult)
                
                 {


                //Player Attack Moves
                if (playerResult == 1)
                {
                    System.Console.WriteLine("You Cast Fireball for 2 damage");
                    damage = dragonHealth - 2;
                }
                else if (playerResult == 2)
                {
                    System.Console.WriteLine("You Cast Inferno for 4 damage");
                    damage = dragonHealth - 4;
                }
                else if (playerResult == 3)
                {
                    System.Console.WriteLine("You cast Blizzard for 6 damage");
                    damage = dragonHealth - 6;
                }
                else if (playerResult == 4)
                {
                    System.Console.WriteLine("You cast Ice Cage for 7 damage");
                    damage = dragonHealth - 7;
                }
                else if (playerResult == 5)
                {
                    System.Console.WriteLine("You cast Hurricane for 8 damage");
                    damage = dragonHealth - 8;
                }
                else if (playerResult == 6)
                {
                    System.Console.WriteLine("You cast Bow The Rainbow for 10 damage");
                }

                return playerResult;
                }

                int DragonAttack(int dragonResult)
                {

                //Dragon Attack Moves
                if (dragonResult == 1)
                {
                    System.Console.WriteLine("The dragon tail slap you for 1 damage");
                    damage = playerHealth - 1;
                }
                else if (dragonResult == 2)
                {
                    System.Console.WriteLine("The dragon tried to headbutt you but missed");
                    damage = playerHealth - 0;
                }
                else if (dragonResult == 3)
                {
                    System.Console.WriteLine("The dragon uses its sharp claws to slice you for 4 damage");
                    damage = playerHealth - 4;
                }
                    
                else if (dragonResult == 4)
                {
                    System.Console.WriteLine("The dragon spit fire from its mouth burning you for 5 damage");
                    damage = playerHealth - 5;
                }
                    
                else if (dragonResult == 5)
                {
                    System.Console.WriteLine("The dragond uses its wings to blow you away dealing 6 damage");
                    damage = playerHealth - 6;
                }
                else if (dragonResult == 6)
                {
                    System.Console.WriteLine("The dragon casts some random attack that disintegrates you dealing 7 damage");
                    damage = playerHealth - 7;
                }

                return dragonResult;
              }
          }
    }
 }
 