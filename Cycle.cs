using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CreateSvgFile
{
    public static void Main()
    {

        string path = @"c:\temp\cycle.html";
        string header = "<html>\n<head></head>\n<body>\n<h1>Cycle</h1>\n";
        string footer = "</body>\n</html>";

        string svg = "";
        svg += "<svg width='500' height='400'>\n";
        svg += "<rect  width='500' height='400' style='fill:rgb(0,0,255);' />\n";
        string parabola = "<path stroke='yellow' stroke-width='5' fill='none' d='";
        for (int i = 0; i <= 500; i++)
        {
            double t = (double)i / 30;
            double r = 2.0;

            double x = r * Math.Sin(3 * t);
            double y = r * Math.Cos(5 * t); ;

            String xs = (x*50 + 150).ToString("0");
            String ys = (- y*50 + 200).ToString("0");
            if (i == 0)
            {
                parabola += " M " + xs + " " + ys;
            }
            else {
                parabola += " L " + xs + " " + ys;
            }
        };
        parabola += " ' />\n";
        svg += parabola;
        svg += "</svg>\n";

        string res = header + svg + footer;
        File.WriteAllText(path, res);
        Console.WriteLine("Ok");
    }
}
