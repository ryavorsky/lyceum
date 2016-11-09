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

        string path = @"c:\temp\picture.html";
        string header = "<html>\n<head></head>\n<body>\n<h1>My first SVG</h1>\n";
        string footer = "</body>\n</html>";

        string svg = "";
        svg += "<svg width='500' height='400'>";
        svg += "<circle cx='50' cy='50' r='40' stroke='green' stroke-width='4' fill='yellow' />\n";

        for (int j = 0; j < 20; j++)
        {
            for (int i = 0; i < 55; i++)
            {
                String xs = (i * 20 + 5).ToString();
                String ys = (j * 20 + 5).ToString();
                String rs = (20+ 15*Math.Sin(i/7)).ToString("0");
                String ws = (1).ToString();
                String color = "rgba(" + (i * 10 + j * 20).ToString() + ", 100," +(i*20+j*10).ToString()+", 0.1)";
                svg += "<circle cx='" + xs + "' cy='" + ys + "' r='" + rs + "' stroke='green' stroke-width='" + ws + "' fill='"+color+"' />\n";
            };
        };
        for (int i = 0; i < 30; i++)
        {
            svg += "<path d='M"+ (i*50).ToString() + " 0 l -35 50 l 70 0 Z' fill='red'/>";
        }
        svg += "</svg>";

        string res = header + svg + footer;
        File.WriteAllText(path, res);
    }
}