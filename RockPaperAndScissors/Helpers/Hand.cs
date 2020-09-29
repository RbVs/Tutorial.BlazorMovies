namespace RockPaperAndScissors.Helpers
{
    public class Hand
    {
        public OptionRPS Selection  { get; set; }
        public OptionRPS WinsAgaings { get; set; }
        public OptionRPS LosesAgaings { get; set; }
        public string Image { get; set; }

        public GameStatus PlayAgainst(Hand opponentHand)
        {
            if (Selection == opponentHand.Selection)
            {
                return GameStatus.Draw;

            }

            if (LosesAgaings == opponentHand.Selection)
            {
                return GameStatus.Loss;
            }

            return GameStatus.Victory;
        }
    }
}