using System;
using System.Collections.Generic;
using System.Text;

namespace Sunburst.Shared
{
	public interface ISunburstItem
	{
		SunburstItemCollection Children { get; }

		object Label { get; }

		double Value { get; }
	}
}
