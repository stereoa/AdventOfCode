namespace AdventOfCode.Solutions.Year2020
{
    public class Bag
    {
        public string Quality { get; private set; }
        public string Color { get; private set; }
        public List<Bag> Bags = new List<Bag>();

        public Bag(string data)
        {
            var bagLayers = data.Split(" contain ");
            var description = bagLayers[0].Split(" ");
            initBag(description[0], description[1]);

            var innerBags = bagLayers[1].Split(", ");
            foreach (var bagGroup in innerBags)
            {
                if (bagGroup == "no other bags.")
                {
                    continue;
                }

                var groupDescription = bagGroup.Split(" ");

                var count = Convert.ToInt32(groupDescription[0]);
                var quality = groupDescription[1];
                var color = groupDescription[2];
                for (var i = 0; i < count; i++)
                {
                    var bag = new Bag(quality, color);
                    Bags.Add(bag);
                }
            }
        }

        public Bag(string quality, string color)
        {
            initBag(quality, color);
        }

        private void initBag(string quality, string color)
        {
            Quality = quality;
            Color = color;
        }
    }
}