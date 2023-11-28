namespace ChessLogic
{
    public enum Player
    {
        None,
        White,
        Black
    }
    public static class PlayerExtensions
    {
        public static Player Opponent(this Player player)
        {
            return player switch
            {
                Player.Black => Player.Black,
                Player.White => Player.White,
                _ => Player.None,
            };
        }
    }
}
