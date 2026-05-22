namespace OBT_Invoices_Master.Models
{
    /// <summary>
    /// this is the class that permit to use the config.json file as a little database
    /// for now, it only reads the name for the window
    /// </summary>
    public class Config
    {
        public List<string> WindowName { get; set; }
    }
}
