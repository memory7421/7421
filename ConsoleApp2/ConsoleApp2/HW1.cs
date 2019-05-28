using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
{
    public partial class HW1
    {
        public Player Player1;
        public Player Player2;

        public HW1()
        {
            Player1 = new Player(PlayerType.Self);
            Player2 = new Player(PlayerType.Enemy);
            Play(Player1, Player2);
        }

        public void Play(Player player1, Player player2)
        {
            RandomEnemy randomEnemy = new RandomEnemy();
            Console.WriteLine(randomEnemy);
            while (player1.HaveMoney() && player2.HaveMoney())
            {
                PlayerAction action = GetAction(Console.ReadLine());
                PlayersChoose player1Choose = new PlayersChoose(player1, action);
                PlayersChoose player2Choose = new PlayersChoose(player2, PlayerAction.Deceive);
                Console.WriteLine(player1Choose + "," + player2Choose);

                Game game = new Game(player1Choose, player2Choose);
                game.PutCoin(player1Choose);
                game.PutCoin(player2Choose);
                game.Judge(player1Choose, player2Choose);

                Console.WriteLine(game);
            }
            Console.WriteLine("\nWinner is " + (player1.Coin > player2.Coin ? player1 : player2));
            Console.WriteLine("遊戲結束");
            Console.ReadLine();
        }

        #region GetAction

        public PlayerAction GetAction(string s) => GetAction(Int32.Parse(s));

        public PlayerAction GetAction(int i)
        {
            switch (i)
            {
                case 0: return PlayerAction.Deceive;
                case 1: return PlayerAction.Cooperation;
                default: throw new Exception();
            }
        }

       
        
        #endregion


    }


}

