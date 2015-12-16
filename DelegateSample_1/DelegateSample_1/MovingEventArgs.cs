using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateSample_1
{
    class MovingEventArgs : EventArgs
    {
        public MovingEventArgs(string messge)
        {
            Message = messge;
        }

        public string Message { get; private set; }
    }

    class SelaryEventArgs : EventArgs
    {
        public SelaryEventArgs(int delta)
        {
            SelaryDelta = delta;
        }
        public int SelaryDelta { get; private set; }
       
    }

}
