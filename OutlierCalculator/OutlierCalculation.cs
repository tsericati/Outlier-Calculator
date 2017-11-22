using System;
using System.Collections.Generic;
using System.Text;

namespace OutlierCalculator
{
    public abstract class OutlierCalculation
    {
		public IEnumerable<double> ObservedData { get; set; }

		public OutlierCalculation(IEnumerable<double> _data)
		{
			ObservedData = _data;
		}

		public OutlierCalculation() : this(new List<double>()) { }

		public abstract double CalculateOutlier(double datapoint);
	}
}
