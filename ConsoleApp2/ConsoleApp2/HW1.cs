using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
{
    public class HW1
    {
        public Player Player1;
        public Player Player2;

        public HW1()
        {
            Player1 = new Player(PlayerType.Self);
            Player2 = new Player(PlayerType.Enemy);
            Play(Player1, Player2);
        }

        public class Game
        {
            public PlayersChoose Player1;
            public PlayersChoose Player2;


            public Game(PlayersChoose player1, PlayersChoose player2)
            {
                Player1 = player1;
                Player2 = player2;
            }

            public void PutCoin(PlayersChoose playerChoose)
            {
                if (playerChoose.Action == PlayerAction.Cooperation) playerChoose.Player.Coin--;
            }

            public Player Judge(PlayersChoose player1, PlayersChoose player2)
            {
                PutCoin(player1);
                PutCoin(player2);
                switch (player1.Action)
                {
                    case PlayerAction.Deceive when player2.Action == PlayerAction.Deceive:
                        return Player.None;
                    case PlayerAction.Cooperation when player2.Action == PlayerAction.Cooperation:
                        player1.Player.Coin += 2;
                        player2.Player.Coin += 2;
                        return Player.Peace;
                    default:
                        return Competition(player1, player2, player1.Action == PlayerAction.Deceive ? player1 : player2);
                }
            }

            public Player Competition(PlayersChoose player1, PlayersChoose player2, PlayersChoose winPlayer)
            {
                player1.Player.Coin--;
                player2.Player.Coin--;
                winPlayer.Player.Coin += +3 + 1;
                return winPlayer.Player;
            }
        }

        public void Play(Player player1, Player player2)
        {
            while (player1.HaveMoney() && player2.HaveMoney())
            {
                PlayerAction action = GetAction(Console.ReadLine());
                PlayersChoose player1Choose = new PlayersChoose(player1, action);
                PlayersChoose player2Choose = new PlayersChoose(player2, PlayerAction.Deceive);
                Console.WriteLine(player1Choose + "," + player2Choose);

                Game result = new Game(player1Choose, player2Choose);
            }
            Console.WriteLine("Winner is " + (player1.Coin > player2.Coin ? player1 : player2));
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

        /*
        public void PlayerPutCoin(PlayerType player, PlayerAction action)
        {
            switch (action)
            {
                case PlayerAction.Deceive:
                    break;
                case PlayerAction.Cooperation:
                    switch (player)
                    {
                        case PlayerType.Self:
                            PlayerCoin--;
                            break;
                        case PlayerType.Enemy:
                            EnemyCoin--;
                            break;
                    }
                    break;
                default: throw new Exception();
            }
            
        }
        */
    }


}

abstract class Person
{
    public abstract bool Action();
}

class Pink : Person
{
    public override bool Action()
    {
        return true;
    }
}

class Black : Person
{
    public override bool Action()
    {
        return false;
    }
}

class Blue : Pink
{
    public new bool Action()
    {
        return base.Action();
    }
}

class Yellow : Pink
{
    public new bool Action()
    {
        if (base.Action() == true)
        {
            return false;
        }
        return base.Action();
    }
}