using System.Xml.Linq;

namespace OBT_Invoices_Master.Utilities
{
    //Let's understand a bit of what's written here under:
    //Public = usable outside of this file (Generic.cs)
    //Static = Can be used without creating an object
    //Class = Here it's used as conteinare for functions
    public class Generic
    {
        public static string IsoDate()
        {
            //explanation:
            //DateTime.Now.ToString() return a DD/MM/YYYY HH:MM:SS string
            //(string).Split(SEPARATOR1) return an array with the elements of string separated by SEPARATOR1
            //array.Reverse() return the array but with the order of component reversed
            //string.join(SEPARATOR2, ARRAY) return a string with the elements of ARRAY united by SEPARATOR2
            //
            //Here below you can find the compressed form!

            string isoDate = string.Join("-", (((DateTime.Now.ToString()).Split(' '))[0].Split('/')).Reverse());
            return isoDate;
        }

        public static string PulisciNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
                return "Sconosciuto";

            foreach (char c in Path.GetInvalidFileNameChars())
            {
                nome = nome.Replace(c, '_');
            }

            return nome;
        }
    }
}