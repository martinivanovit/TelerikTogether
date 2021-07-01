using System.Collections.Generic;

namespace TelerikTogether.Sunburst
{
    public class SunburstLayoutEngine
	{
		public SunburstLayoutEngine()
		{
		}

		public double StartAngle { get; set; }

		public int MaxLevel { get; private set; }

		public IEnumerable<SunburstItemViewInfo> CalculateViewInfos(SunburstItemCollection items)
		{
			foreach (SunburstItemViewInfo viewInfo in this.CalculateViewInfos(items, 0, this.StartAngle, 360d))
			{
				yield return viewInfo;
			}
		}

		private IEnumerable<SunburstItemViewInfo> CalculateViewInfos(SunburstItemCollection items, int level, double startAngle, double sweepAngle)
		{
			double sumTotal = items.Total;
			double currentAngle = startAngle;

			foreach (ISunburstItem item in items)
			{
				SunburstItemViewInfo viewInfo = new SunburstItemViewInfo();
				viewInfo.Label = item.Label.ToString();
				viewInfo.StartAngle = currentAngle;
				viewInfo.SweepAngle = item.Value / sumTotal * sweepAngle;
				viewInfo.Level = level;

				if (level > this.MaxLevel)
				{
					this.MaxLevel = level;
				}

				yield return viewInfo;

				if (item.Children != null)
				{
					foreach (SunburstItemViewInfo vi in this.CalculateViewInfos(item.Children, level + 1, currentAngle, viewInfo.SweepAngle))
					{
						yield return vi;
					}
				}

				currentAngle += viewInfo.SweepAngle;
			}
		}
	}
}
