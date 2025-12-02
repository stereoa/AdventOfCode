namespace AdventOfCode.AdventOfCode.Solutions.Year2020.Day05
{
    internal class BoardingPass
    {
        public BoardingPass(string i)
        {
            var seatId = i.Replace('F', '0')
                          .Replace('B', '1')
                          .Replace('L', '0')
                          .Replace('R', '1');
            SeatId = Convert.ToInt32(seatId, 2);
        }

        public int SeatId { get; internal set; }
    }
}