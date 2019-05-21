namespace ConsoleApp2
{
    public partial class HW1
    {
        public class Game
        {
            public PlayersChoose Player1;
            public PlayersChoose Player2;
            public Player Winner;
            public Game(PlayersChoose player1, PlayersChoose player2)
            {
                Player1 = player1;
                Player2 = player2;
            }

            public void PutCoin(PlayersChoose playerChoose)
            {
                if (playerChoose.Action == PlayerAction.Cooperation) playerChoose.Player.Coin--;
            }

            public void Judge(PlayersChoose player1, PlayersChoose player2)
            {
                PutCoin(player1);
                PutCoin(player2);
                switch (player1.Action)
                {
                    case PlayerAction.Deceive when player2.Action == PlayerAction.Deceive:
                        Winner = Player.None;
                        return;
                    case PlayerAction.Cooperation when player2.Action == PlayerAction.Cooperation:
                        player1.Player.Coin += 2;
                        player2.Player.Coin += 2;
                        Winner = Player.Peace;
                        return;
                    default:
                        Winner = Competition(player1, player2, player1.Action == PlayerAction.Deceive ? player1 : player2);
                        return;
                }

            }

            public Player Competition(PlayersChoose player1, PlayersChoose player2, PlayersChoose winPlayer)
            {
                player1.Player.Coin--;
                player2.Player.Coin--;
                winPlayer.Player.Coin += +3 + 1;
                return winPlayer.Player;
            }
            public override string ToString() => $"winner is {Winner}\nplayer1's coin {Player1.Player.Coin}\nplayer2's coin {Player2.Player.Coin}";
        }
        

       
    }


}
