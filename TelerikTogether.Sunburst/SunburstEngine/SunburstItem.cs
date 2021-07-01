namespace TelerikTogether.Sunburst
{
    public class SunburstItem : ISunburstItem
	{
		private SunburstItemCollection children;
		private object label;
		private double value;

		public SunburstItem(SunburstItemCollection children, object label, double value)
		{
			this.children = children;
			this.label = label;
			this.value = value;
		}

		public SunburstItemCollection Children
		{
			get { return this.children; }
			set { this.children = value; }
		}

		public object Label
		{
			get { return this.label; }
			set { this.label = value; }
		}

		public double Value
		{
			get { return this.value; }
			set { this.value = value; }
		}
	}
}
