using System;

class GenerateSVG {
	public static int Main() {
		var height = 400UL;
		var width  = 500UL;

		var svgContent = "<circle cx=\"50\" cy=\"50\" r=\"40\" stroke=\"green\" stroke-width=\"4\" fill=\"yellow\"/>";

		for(var idx = 0UL; idx < 5; idx += 1) {
			var centerX = idx * 50 + 50;
			var centerY = idx * 30 + 145;
			var radius = idx * idx * 3 + 25;

			var circle = String.Format(
				"<circle cx=\"{0}\" cy=\"{1}\" r=\"{2}\" stroke=\"green\" stroke-width=\"{3}\" fill=\"blue\"/>",
				centerX, centerY, radius, idx);

			svgContent = String.Concat(svgContent, circle);
		}

		var svgElement = String.Format(
			"<svg width=\"{0}\" height=\"{1}\">{2}</svg>",
			width, height, svgContent);

		var bodyContent = String.Format(
			"<h1>My first SVG</h1>{0}",
			svgElement);

		var htm = String.Format(
			"<!DOCTYPE html><meta charset=\"utf-8\"><title>Generated SVG</title><body>{0}</body>",
			bodyContent);

		Console.WriteLine(htm);

		return 0;
	}
}
