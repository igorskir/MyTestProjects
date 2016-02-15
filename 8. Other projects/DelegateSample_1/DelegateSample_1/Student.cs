using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegateSample_1
{
    //delegate void ShowMessage(string message);
    class Student
    {
        public void Move(int distance, Action<string> method)
        {
            for (int i = 1; i <= distance; i++)
            {
                Thread.Sleep(1000);
                if(Moving != null)
                    Moving(this, new MovingEventArgs(string.Format("Student are moveing...k/m are gone: {0}", i)));
                
            }
        }
        public event EventHandler<MovingEventArgs> Moving;
    } 
}
