using System;


namespace Facade_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 1
            TextEditor textEditor = new TextEditor();
            Compiller compiller = new Compiller();
            CLR clr = new CLR();
            VisualStudioFacade facade = new VisualStudioFacade(textEditor, compiller, clr);
            // 2
            VisualStudioFacade f = new VisualStudioFacade(new TextEditor(), new Compiller(), new CLR());

            f.Start();
            f.Stop();

            Programmer programmer = new Programmer();
            programmer.CreateApplication(facade);
            programmer.CreateApplication(f);

            Console.ReadLine();
        }
    }
}