using static MySolarSystem.Program;

namespace MySolarSystem
{
    public class SolarSystem
    {
        private List<Planet> planets;

        public SolarSystem()
        {
            planets = new List<Planet>();
        }

        public void AddPlanet(Planet planet)
        {
            planets.Add(planet);
        }
        public void DisplayPlanets()
        {
            foreach (var planet in planets)
            {
                string type = planet.Name == "Sun" ? "Star" : "Planet";
                Console.WriteLine($"{type}: {planet.Name}. Radius: {planet.Radius} km. Volume: {planet.Volume} km^3");
            }
        }
    }
}
