using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Rectangle
    {

        //member variables 
        private int newLenght;
        private int newWidth;

        //accessor Methods;
        public int getLenght()
        {
            return newLenght;
        }

        public int getWidth()
        {
            return newWidth;
        }
    
    //Mutator Methods 
        public void setLength(int length) { newLenght = length; }
        public void setWidth(int width) { newWidth = width; }
        public int CalculateArea() { return newWidth * newLenght; }
    
    
    
    }
}
