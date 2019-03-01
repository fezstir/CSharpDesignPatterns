using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface ISpeedChange
    {//method declaratio that takes two types    
        void ValueHasChanged(object sender, EventArgs args);
    }
}
