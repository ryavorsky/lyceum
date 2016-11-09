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

        for (int i = 0; i < 5; i++)
        {
            String xs = (i*50 + 50).ToString();
            String ys = (i*30 + 145).ToString();
            String rs = (i * i * 3 + 25).ToString();
            String ws = i.ToString();
            svg += "<circle cx='" + xs + "' cy='" + ys +"' r='" + rs + "' stroke='green' stroke-width='"+ws+"' fill='blue' />\n";
        };
        svg += "</svg>";

        string res = header + svg + footer;
        File.WriteAllText(path, res);
        Console.WriteLine("Ok");
    }
}
