namespace AdventOfCode.Models
{
    public class Map
    {
        public MapTile[,] Tiles { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Map(string input)
        {
            ParseMap(input);
        }

        private void ParseMap(string input)
        {
            var lines = input.SplitByNewline();

            Width = lines.Max(l => l.Length);
            Height = lines.Length;
            Tiles = new MapTile[Width, Height];

            var y = 0;
            foreach (var line in lines)
            {
                for (var x = 0; x < Width; x++)
                {
                    if (line[x] == '.')
                    {
                        Tiles[x, y] = new EmptyTile();
                    }
                    else if (line[x] == '#')
                    {
                        Tiles[x, y] = new TreeTile();
                    }
                }
                y++;
            }
        }

        public uint CalculateCollisions(List<Slope> slopes)
        {
            var collisionCounts = new List<uint>();
            foreach (var slope in slopes)
            {
                collisionCounts.Add(CalculateSlopeCollisions(slope));
            }
            var total = collisionCounts.Aggregate((x, y) => (x * y));
            return total;
        }

        public uint CalculateSlopeCollisions(Slope slope)
        {
            uint treeCount = 0;
            var x = slope.X;
            for (var y = slope.Y; y < Height; y += slope.Y)
            {
                if (Tiles[x, y] is TreeTile)
                {
                    treeCount++;
                }
                x += slope.X;
                if (x >= Width)
                {
                    x -= Width;
                }
            }
            return treeCount;
        }

    }
}
