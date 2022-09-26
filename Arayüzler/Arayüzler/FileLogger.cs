using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arayüzler
{
    internal class FileLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Dosyaya Log yazar");
        }
    }
}
