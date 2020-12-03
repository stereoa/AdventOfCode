namespace AdventOfCode.Models
{
    class Map
    {
        public MapTile[,] Tiles { get; set; }
        public int Width { get; }
        public int Height { get; }

        public Map(int width, int height)
        {
            Width = width;
            Height = height;
            Tiles = new MapTile[width, height];
        }
    }
}
