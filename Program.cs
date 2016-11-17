using System;

public class GenerateSVG {
	public static int Main() {
		var width = 500UL;
		var height = 400UL;

		var svgContent = "<circle cx=\"50\" cy=\"50\" r=\"40\" stroke=\"green\" stroke-width=\"4\" fill=\"yellow\"/>";

		for(var j = 0L; j < 20; j++) for(var i = 0L; i < 55; i++) {
			var centerX = i * 20 + 5;
			var centerY = j * 20 + 5;
			var radius = 20 + 15 * Math.Sin(i / 7);
			var strokeWidth = 1;

			var color = String.Format(
				"rgba({0}, 100, {1}, 0.1)",
				i * 10 + j * 20,
				i * 20 + j * 10);

			var circleElement = String.Format(
				"<circle cx=\"{0}\" cy=\"{1}\" r=\"{2}\" stroke='green' stroke-width=\"{3}\" fill=\"{4}\"/>",
				centerX, centerY, radius,
				strokeWidth, color);

			svgContent = String.Concat(svgContent, circleElement);
		}

		for(var i = 0UL; i < 30; i++) {
			var pathElement = String.Format("<path d=\"M{0} 0 l -35 50 l 70 0 Z\" fill=\"red\"/>", i * 50);
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
