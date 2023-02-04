namespace ConsoleApp61
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            switch (word)
            {
                case "basic":
                    DocumentProgram initialVersion = new DocumentProgram();
                    initialVersion.OpenDocument();
                    initialVersion.EditDocument();
                    initialVersion.SaveDocument();
                    break;
                case "pro":
                    ProDocumentProgram midVersion = new ProDocumentProgram();
                    midVersion.EditDocument();
                    midVersion.SaveDocument();
                    break;
                case "expert":
                    ExpertDocumentProgram latestVersion = new ExpertDocumentProgram();
                    latestVersion.SaveDocument();
                    break;
                default:
                    Console.WriteLine("Enter word correctly,please!");
                    break;

            }
        }
    }
}