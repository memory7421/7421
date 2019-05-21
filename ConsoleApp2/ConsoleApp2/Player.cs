namespace ConsoleApp2
{
    public class Player
    {
        public static Player Peace = new Player(PlayerType.Peace);
        public static Player None = new Player(PlayerType.Null);

        public PlayerType PType;
        public int Coin = 5;

        public Player(PlayerType playerType)
        {
            PType = playerType;
        }

        public override string ToString() => PType.ToString();

        public bool HaveMoney() => Coin > 0;
    }

    public enum PlayerType
    {
        Null, Peace, Self, Enemy
    }
}