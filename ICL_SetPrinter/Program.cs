// See https://aka.ms/new-console-template for more information
Console.WriteLine("Copy Print file to Backup - Version (2.0.0.0)");
Console.WriteLine("Author Philip Chaston = @Systems Ltd 2015 ");
Console.WriteLine(" ");
Console.WriteLine("EXEC File? type G3EXEC ");
Console.WriteLine("CHANGE CORE SIZE? type N ");
Console.WriteLine("ENTER DATE...type TUE25OCT17 ");
Console.WriteLine("ENTER TIME...type 1000 ");
Console.WriteLine("Found on Unit ?? type Tab - DA GEORGE3A ");
Console.WriteLine("GEORGE READY type MOP ON,27(If not loaded) ");
Console.WriteLine("RESTORE - N ");
Console.WriteLine("  ");

var myUniqueFileName1 = "C:\\em1900\\Line_Printer\\" + string.Format(@"{0}.txt", Guid.NewGuid());
var myUniqueFileName2 = "C:\\em1900\\Line_Printer\\" + string.Format(@"{0}.txt", Guid.NewGuid());
if  (Directory.Exists("C:\\em1900\\Line_Printer\\"))

    {
    using (StreamWriter w = File.AppendText(myUniqueFileName1))
        {
        Log("C:\\em1900\\Line_Printer\\lp14.txt", w);
        }
    using (StreamWriter w = File.AppendText(myUniqueFileName2))
        {
        Log("C:\\em1900\\Line_Printer\\lp15.txt", w);
        }
    }
 

void Log(String filename1, TextWriter w)
{
    int counter = 0;
    string line;
    try
    {
        w.Write("\r\nLog Entry : ");
        w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
            DateTime.Now.ToLongDateString());
        w.WriteLine("  :");
        // Read the file and display it line by line.
        System.IO.StreamReader file =
           new System.IO.StreamReader(filename1);
        while ((line = file.ReadLine()) != null)
        {
            w.WriteLine("{0}", line);
            counter++;
        }
        w.WriteLine("-------------------------------");
        file.Close();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    File.Delete(filename1);
}

Console.WriteLine(" ");
Console.WriteLine("LP Print Files Copied ");
