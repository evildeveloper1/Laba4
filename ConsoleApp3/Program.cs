using System;
using System.Collections.Generic;
interface IConnectable
{
    void Connect(Computer target);
    void Disconnect(Computer target);
    void TransferData(Computer target, string data);
}
class Computer
{
    public string IPAddress { get; set; }
    public int Power { get; set; }
    public string OperatingSystem { get; set; }
}
class Server : Computer
{
}
class Workstation : Computer
{
}
class Router : Computer
{
}
class Network
{
    private List<Computer> computers;

    public Network()
    {
        computers = new List<Computer>();
    }

    public void AddComputer(Computer computer)
    {
        computers.Add(computer);
    }

    public void ConnectComputers(Computer source, Computer target)
    {
        if (computers.Contains(source) && computers.Contains(target))
        {
            if (source is IConnectable connectableSource)
            {
                connectableSource.Connect(target);
            }
        }
    }

    public void DisconnectComputers(Computer source, Computer target)
    {
        if (computers.Contains(source) && computers.Contains(target))
        {
            if (source is IConnectable connectableSource)
            {
                connectableSource.Disconnect(target);
            }
        }
    }
    public void TransferData(Computer source, Computer target, string data)
    {
        if (computers.Contains(source) && computers.Contains(target))
        {
            if (source is IConnectable connectableSource)
            {
                connectableSource.TransferData(target, data);
            }
        }
    }
}
class Program
{
    static void Main()
    {
        Network network = new Network();

        Server server = new Server { IPAddress = "192.168.0.1", Power = 1000, OperatingSystem = "Windows Server" };
        Workstation workstation = new Workstation { IPAddress = "192.168.0.2", Power = 500, OperatingSystem = "Windows 10" };
        Router router = new Router { IPAddress = "192.168.0.3", Power = 200, OperatingSystem = "RouterOS" };

        network.AddComputer(server);
        network.AddComputer(workstation);
        network.AddComputer(router);

        network.ConnectComputers(server, workstation);
        network.TransferData(server, workstation, "Hello, Workstation!");

        network.DisconnectComputers(server, workstation);
    }
}
