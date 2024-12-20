using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct Point 
    {
        // Attributr 
        public int X;
        public int Y;
        //------------------------
        // Constructor  : is spectial Function 
        //1- Named Alwaye with Same Name Class or Struct 
        //2- Has No Return
        
        public Point()
        {
            X= 0;
            Y= 0;
        }
        public Point(int _X ,int _Y)
        {
            X = _X;
            Y = _Y;

        }
        //Method
        public override string ToString()
        {
            return base.ToString();
            {
                return $"the X={X} :{Y}";
            }
        }
    }
}
