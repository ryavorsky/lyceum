using System;

public class GenerateSVG {
	public static int Main() {
		var height = 400UL;
		var width  = 500UL;

		var svgContent = "<circle cx=\"50\" cy=\"50\" r=\"40\" stroke=\"brown\" stroke-width=\"2\" fill=\"yellow\"/>";

		for(var j = 0; j < 20; j += 1) for(var i = 0; i < 50; i += 1) {
			var red = j * 10;
			var green = i * 5;
			var color = String.Format(
				"rgba({0}, {1}, 90, 0.5)",
				red, green);

			var centerX = 5 + i * 20;
			var centerY = 5 + j * 20;
			var radius = 7 + 4 * Math.Sin((i * i + j * j) / 2);

			var strokeWidth = 1;

			var circleElement = String.Format(
				"<circle cx=\"{0}\" cy=\"{1}\" r=\"{2}\" stroke=\"green\" stroke-width=\"{3}\" fill=\"{4}\"/>",
				centerX, centerY, radius, strokeWidth, color);

			svgContent = String.Concat(svgContent, circleElement);
		}

		for(var a = 0; a < 10; a += 1) {
			var pathElement = String.Format(
				"<path d=\"M {0} {1} l-75 150 l 150 0 Z\" fill=\"rgba(43,13,130,0.3)\"/>",
				a * 100, a * 15);
			svgContent = String.Concat(svgContent, pathElement);
		}

		var svgElement = String.Format("<svg width=\"{0}\" height=\"{1}\">{2}</svg>",
			width, height, svgContent);

		var bodyContent = String.Format("<h1>My first SVG</h1>{0}", svgElement);

		var htm = String.Format(
			"<!DOCTYPE html><meta charset=\"utf-8\"><title>Generated SVG</title><body>{0}</body>",
			bodyContent);

		Console.WriteLine(htm);

		return 0;
	}
}
