using System;
class Road
{
    public double Length { get; set; }
    public double Width { get; set; }
    public int Lanes { get; set; }
    public int TrafficLevel { get; set; }
}
class Vehicle
{
    public int Speed { get; set; }
    public string Size { get; set; }
    public string Type { get; set; }
}
interface IDriveable
{
    void Move();
    void Stop();
}
class TrafficSimulation
{
    public void SimulateMovement(Vehicle vehicle, Road road)
    {
        if (vehicle.Speed > 0 && road.TrafficLevel < 3)
        {
            Console.WriteLine($"The vehicle is moving on the road with {road.Lanes} lanes.");
        }
        else
        {
            Console.WriteLine("The vehicle is stopped due to heavy traffic or road conditions.");
        }
    }
}

class Program
{
    static void Main()
    {
        Road road = new Road { Length = 10, Width = 2, Lanes = 2, TrafficLevel = 2 };
        Vehicle car = new Vehicle { Speed = 60, Size = "Medium", Type = "Car" };

        TrafficSimulation simulator = new TrafficSimulation();
        simulator.SimulateMovement(car, road);
    }
}
