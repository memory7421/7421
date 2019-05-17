namespace ConsoleApp2
{
    public class PlayersChoose
    {
        public Player Player;
        public PlayerAction Action;

        public  PlayersChoose(Player player,PlayerAction action)
        {
            Player = player;
            Action = action;
        }

        public override string ToString()
        {
            return Player.PType + "選擇" + Action;
        }
    }
}