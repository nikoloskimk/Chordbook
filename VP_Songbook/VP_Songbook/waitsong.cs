using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VP_Songbook
{
    public partial class waitsong
    {
        public override string ToString()
        {
            return this.author_waitsong + " - " + this.name_waitsong;
        }
    }
}
