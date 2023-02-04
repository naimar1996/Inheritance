using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp61
{
    public class ExpertDocumentProgram : ProDocumentProgram
    {
        public override void SaveDocument()
        { 
        Console.WriteLine("Document Saved in pdf format");
        }
    }
}
