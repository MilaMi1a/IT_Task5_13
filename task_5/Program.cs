
using task_5;

internal class Program
{
    private static void Main(string[] args)
    {
        List<TransportVehicle> list = new List<TransportVehicle>();
        list.Add(new Tram(2, 3, 15));
        list.Add(new Tram(3, 2, 10));
        list.Add(new Tram(1, 3, 20));

        foreach (Tram vehicle in list) {
            vehicle.go();
            vehicle.addPassangers();
            vehicle.addPassangers();

            vehicle.removePassangers();
            vehicle.stop();
        }
    }

}