using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class VerbEventArgs : EventArgs
    {
        public bool IsEven { get; set; }

        public VerbEventArgs(bool isEven)
        {
            this.IsEven = isEven;
        }
    }
}
