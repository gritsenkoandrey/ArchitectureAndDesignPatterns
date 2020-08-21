using System;


namespace Composite_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Component fileSystem = new Directory("File system");
            Component disc = new Directory("Disc C");
            Component png = new File("PNG File");
            Component docx = new File("DOCX File");

            fileSystem.Add(png);
            fileSystem.Add(docx);
            disc.Add(png);
            disc.Add(docx);
            //fileSystem.Remove(png);
            //fileSystem.Remove(docx);
            fileSystem.Print();
            disc.Print();

            Console.ReadLine();
        }
    }
}