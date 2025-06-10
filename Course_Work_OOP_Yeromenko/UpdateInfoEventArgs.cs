using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work_OOP_Yeromenko
{
    public class UpdateInfoEventArgs : EventArgs
    {
        public Criminal oldCriminal;
        public Criminal newCriminal;
        public UpdateInfoEventArgs(Criminal oldCriminal, Criminal newCriminal) 
        {
            this.oldCriminal = oldCriminal;
            this.newCriminal = newCriminal;
        }
    }
}
