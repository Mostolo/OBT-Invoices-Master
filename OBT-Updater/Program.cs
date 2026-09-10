using System.Diagnostics;

if (args.Length < 4)
{
    Console.WriteLine("Argomenti insufficienti");
    return;
}
else if (args.Length > 4)
{
    Console.WriteLine("Troppi argomenti");
    return;
}

string zipPath  = args[0];
string targetDirectory  = args[1];
int processId = int.Parse(args[2]);
string exeName = args[3];

Console.WriteLine("ZIP: " + zipPath);
Console.WriteLine("Cartella OBT-Invoice-Master: " + targetDirectory);
Console.WriteLine("PID OBT-Invoice-Master: " + processId);
Console.WriteLine("EXE OBT-Invoice-Master: " + exeName);

try
{
    Process obtProcess = Process.GetProcessById(processId);

    Console.WriteLine("\nOBT-Invoice-Master è ancora aperto\nAttendere che venga chiuso...");

    obtProcess.WaitForExit();

    Console.WriteLine("OBT-Invoice-Master è stato chiuso correttamente!");
}
catch (ArgumentException)
{
    Console.WriteLine("\nIl processo OBT-Invoice-Master non esiste più");
}