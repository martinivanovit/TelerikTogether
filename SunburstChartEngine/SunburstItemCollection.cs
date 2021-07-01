﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Sunburst.Shared
{
	public class SunburstItemCollection : ObservableCollection<ISunburstItem>
	{
		public double Total
		{
			get { return this.Sum(x => x.Value); }
		}
	}
}
