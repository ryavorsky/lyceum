using System;

public class GenerateSVG {
	public static int Main() {
		var width = 500U;
		var height = 400U;

		var pathDescriptions = "M50 0";
		for(var i = 0L; i <= 200; i += 1) {
			var x = (double)(i  - 100) / 50d;
			var y = x * x;

			var argX = (150 + x * 50).ToString("0");
			var argY = (200 - y * 50).ToString("0");

			var command = String.Format(" L {0} {1} ", argX, argY);

			pathDescriptions = String.Concat(pathDescriptions, command);
		}

		var svgContent = String.Format(
			"<rect width=\"{0}\" height=\"{1}\" style=\"fill:rgb(0,0,255)\"/>",
			width, height);

		var pathElement = String.Format(
			"<path stroke=\"black\" stroke-width=\"2\" fill=\"none\" d=\"{0}\"/>",
			pathDescriptions);

		svgContent = String.Concat(svgContent, pathElement);

		var svgElement = String.Format("<svg width=\"{0}\" height=\"{1}\">{2}</svg>",
			width, height, svgContent);

		var bodyContent = String.Format("<h1>Parabola</h1>{0}", svgElement);

		var htm = String.Format(
			"<!DOCTYPE html><meta charset=\"utf-8\"><title>Generated SVG</title><body>{0}</body>",
			bodyContent);

		Console.WriteLine(htm);

		return 0;
	}
}
