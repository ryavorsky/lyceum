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

        string path = @"c:\temp\parabola.html";
        string header = "<html>\n<head></head>\n<body>\n<h1>Parabola</h1>\n";
        string footer = "</body>\n</html>";

        string svg = "";
        svg += "<svg width='500' height='400'>\n";
        svg += "<rect  width='500' height='400' style='fill:rgb(0,0,255);' />\n";
        string parabola = "<path stroke='yellow' stroke-width='5' fill='none' d='M50 0 ";
        for (int i = 0; i <= 200; i++)
        {
            float x = ( (float) i  - 100) / 50;
            float y = x * x;

            String xs = (x*50 + 150).ToString("0");
            String ys = (- y*50 + 200).ToString("0");
            parabola += " L " + xs + " " + ys;
        };
        parabola += " ' />\n";
        svg += parabola;
        svg += "</svg>\n";

        string res = header + svg + footer;
        File.WriteAllText(path, res);
        Console.WriteLine("Ok");
    }
}
