using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VP_Songbook
{
    public partial class song
    {
        public override string ToString()
        {
            return this.author + " - " + this.name;
        }
    }
}
