namespace MySolarSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            var solarSystem = new SolarSystem();
            solarSystem.AddPlanet(new Planet("Mercury", 2439));
            solarSystem.AddPlanet(new Planet("Venus", 6051));
            solarSystem.AddPlanet(new Planet("Earth", 6371));
            solarSystem.AddPlanet(new Planet("Mars", 3389));
            solarSystem.AddPlanet(new Planet("Jupiter", 69911));
            solarSystem.AddPlanet(new Planet("Saturn", 58232));
            solarSystem.AddPlanet(new Planet("Uranus", 25362));
            solarSystem.AddPlanet(new Planet("Neptune", 24622));
            solarSystem.AddPlanet(new Planet("Pluto", 1188));
            solarSystem.AddPlanet(new Planet("UrMom", 696969));
            solarSystem.AddPlanet(new Planet("Sun", 696340));

            solarSystem.DisplayPlanets();

            Console.ReadKey();
        }
    }
}