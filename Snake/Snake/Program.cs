using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');
            p1.Draw();

            Point p2 = new Point(6, 8, '$');
            p2.Draw();
                        
            HorizontalLine lineHor = new HorizontalLine(5,10,8,'+');
            lineHor.DrawHoriz();

            VerticalLine lineVer = new VerticalLine(8, 16, 10, '+');
            lineVer.DrawVertical();


            Console.ReadLine();
        }
        

        
    }
}
