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

        string path = @"c:\temp\svgpic1.html";

        string header = "<html>\n<head></head>\n<body>\n<h1>My first SVG</h1>\n";
        string footer = "</body>\n</html>";

        string svg = "";
        svg += "<svg width='500' height='400'>";
        svg += "<circle cx='50' cy='50' r='40' stroke='brown' stroke-width='2' fill='yellow' />\n";

        for (int j = 0; j < 20; j++)
        {
            for (int i = 0; i < 50; i++)
            {
                int x = 5 + i * 20;
                int y = 5 + j * 20;
                String gr = (i*5).ToString();
                String red = (j * 10).ToString();
                String color = "rgba(" + red + ", "+ gr +", 90, 0.5)";
                String xs = (x).ToString();
                String ys = (y).ToString();
                String rs = (7 + 4*Math.Sin((i*i+j*j)/2)).ToString("0");
                String ws = (1).ToString();
                svg += "<circle cx='" + xs + "' cy='" + ys + "' r='" + rs + "' stroke='green' stroke-width='" 
                    + ws + "' fill='" + color +
                    "' />\n";
            };
        };
        for (int a = 0; a < 10; a++)
        {

            svg += "<path d='M " + (a*100).ToString() + " " + (a*15).ToString() + " l-75 150 l 150 0 Z' fill='rgba(43,13,130,0.3)' />";
        };
        svg += "</svg>";

        string res = header + svg + footer;
        File.WriteAllText(path, res);
        
    }
}

