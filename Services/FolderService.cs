using OBT_Invoices_Master.Utilities;
using System.Xml.Linq;

namespace OBT_Invoices_Master.Services
{
    public class FolderService
    {
        //let's try and deconstruct this big ass function
        public static void SaveCsv(string folder, string[] path)
        {
            InvoiceService invoiceService = new();
            invoiceService.ProcessFolder(folder);
        }

        /// <summary>
        /// this function create a folder in the designated folder path
        /// </summary>
        /// <param name="folderPath">where you want your new folder</param>
        /// <param name="folderName">the name for the new folder</param>
        public static string CreateFolderHere(string folderPath, string folderName)
        {
            string newfolder = Path.Combine(folderPath, folderName);
            Directory.CreateDirectory(newfolder);

            return newfolder;
        }
    }
}
