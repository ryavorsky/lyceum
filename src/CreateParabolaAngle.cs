using System;

public class CreateSvgFile {
	public static int Main() {
		var width = 500U;
		var height = 400U;

		var pathDescriptions = "";
		for(var idx = 0L; idx <= 200; idx += 1) {
			var x = (double)(idx - 100) / 50;
			var y = x * x;
			var angle = 1.8d;

			var x1 = x * Math.Cos(angle) + y * Math.Sin(angle);
			var y1 = y * Math.Cos(angle) - x * Math.Sin(angle);

			var argX = (x1 * 50 + 150).ToString("0");
			var argY = (200 - y1 * 50).ToString("0");

			var instruction = (idx == 0) ? "M" : "L";
			var command = String.Format("{0} {1} {2} ",
				instruction, argX, argY);

			pathDescriptions = String.Concat(pathDescriptions, command);
		}

		var svgContent = String.Format(
			"<rect width=\"{0}\" height=\"{1}\" style=\"fill:rgb(0,0,255)\"/>",
			width, height);
		var pathElement = String.Format(
			"<path stroke=\"yellow\" stroke-width=\"4\" fill=\"none\" d=\"{0}\"/>",
			pathDescriptions);

		svgContent = String.Concat(svgContent, pathElement);

		var svgElement = String.Format("<svg width=\"{0}\" height=\"{1}\">{2}</svg>",
			width, height, svgContent);

		var bodyContent = String.Format("<h1>Parabola + angle</h1>{0}", svgElement);

		var htm = String.Format(
			"<!DOCTYPE html><meta charset=\"utf-8\"><title>Generated SVG</title><body>{0}</body>",
			bodyContent);

		Console.WriteLine(htm);

		return 0;
	}
}
