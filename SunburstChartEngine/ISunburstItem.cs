using System;
using System.Collections.Generic;
using System.Text;

namespace TelerikTogether.Sunburst
{
	public interface ISunburstItem
	{
		SunburstItemCollection Children { get; }

		object Label { get; }

		double Value { get; }
	}
}
