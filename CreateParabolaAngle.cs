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

        string path = @"c:\temp\parabola1.html";
        string header = "<html>\n<head></head>\n<body>\n<h1>Parabola + angle</h1>\n";
        string footer = "</body>\n</html>";

        string svg = "";
        svg += "<svg width='500' height='400'>\n";
        svg += "<rect  width='500' height='400' style='fill:rgb(0,0,255);' />\n";
        string parabola = "<path stroke='yellow' stroke-width='5' fill='none' d='";
        for (int i = 0; i <= 200; i++)
        {
            double x = ((double)i - 100) / 50;
            double y = x * x;
            double angle = 1.8;
            double x1 = x * Math.Cos(angle) + y * Math.Sin(angle);
            double y1 = -x * Math.Sin(angle) + y * Math.Cos(angle);

            String xs = (x1*50 + 150).ToString("0");
            String ys = (- y1*50 + 200).ToString("0");
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
