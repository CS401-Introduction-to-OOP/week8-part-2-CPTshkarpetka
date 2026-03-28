using Week8;

var file = new FileResource("report.txt");
var network = new NetworkResource("api.company.local");
var manager = new ResourceManager<Resource>();
manager.Add(file);
manager.Add(network);
manager.OpenAll();
using (var tempResource = new FileResource("temporary_data.tmp"))
{
    tempResource.Open();
}
manager.CloseAll();
Console.WriteLine("Done.");