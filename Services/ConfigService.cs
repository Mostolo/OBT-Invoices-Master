using System.Text.Json;
using OBT_Invoices_Master.Models;

namespace OBT_Invoices_Master.Services
{
	public class ConfigService
	{
        public static string SetRandomWindowTitle()
        {
            string name = "Qualcosa è andato storto..."; //called like this because if something happens, you'll notice
            string ourJson = File.ReadAllText("Config.json"); //here it finds the JSON file
            Config config = JsonSerializer.Deserialize<Config>(ourJson)!; //here it uses our configmodel.cs file to read and temporarly save the information in the json file

            Random rnd = new(); //for random number
            name = config.WindowName[rnd.Next(config.WindowName.Count)]; //in order: find the lenght of the name array, pick a random number, pick the name in that position
            return name;
        }
    }
}
