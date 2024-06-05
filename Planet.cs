namespace MySolarSystem
{
    public class Planet
    {
        internal static object _Name;

        public string Name { get; }
        public int Radius { get; set; }
        public double Volume => CalculateVolume();

        public Planet(string name, int radius)
        {
            Name = name;
            Radius = radius;
        }

        private double CalculateVolume()
        {
            return 4.0 / 3.0 * Math.PI * Math.Pow(Radius, 3);
        }
    }
}
