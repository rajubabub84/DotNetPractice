using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPDemo
{
    interface IPrintScanContent
    {
        bool PrintContent(string content);
        bool ScanContent(string content);
        bool PhotoCopyContent(string content);
    }
    interface IFaxContent
    {
        bool FaxContent(string content);
    }

    interface IDuplexContent
    {
        bool PrintDupleContent(string content);
    }
}
