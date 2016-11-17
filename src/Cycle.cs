using System;

public class GenerateSVG {
	public static int Main() {
		var width = 500U;
		var height = 400U;

		var pathDescriptions = "";
		for(var idx = 0UL; idx <= 500; idx += 1) {
			var t = (Double)idx / 30d;
			var r = 2d;

			var x = r * Math.Sin(3 * t);
			var y = r * Math.Cos(5 * t); ;

			var argX = 150 + x * 50;
			var argY = 200 - y * 50;

			var instruction = (idx == 0) ? "M" : "L";
			var command = String.Format("{0} {1:0} {2:0} ",
				instruction, argX, argY);

			pathDescriptions = String.Concat(
				pathDescriptions, command);
		}

		var svgContent = String.Format(
			"<rect width=\"{0}\" height=\"{1}\" style=\"fill:rgb(0,0,255)\"/>",
			width, height);
		var pathElement = String.Format(
			"<path stroke=\"yellow\" stroke-width=\"5\" fill=\"none\" d=\"{0}\"/>",
			pathDescriptions);

		svgContent = String.Concat(svgContent, pathElement);

		var svgElement = String.Format(
			"<svg width=\"{0}\" height=\"{1}\">{2}</svg>",
			width, height, svgContent);

		var bodyContent = String.Format(
			"<h1>Cycle</h1>{0}",
			svgElement);

		var htm = String.Format(
			"<!DOCTYPE html><meta charset=\"utf-8\"><title>Generated SVG</title><body>{0}</body>",
			bodyContent);

		Console.WriteLine(htm);

		return 0;
	}
}
