using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput HistogramFixedWidth(this TFGraph graph, TensorFlow.TFOutput values, TensorFlow.TFOutput value_range, TensorFlow.TFOutput nbins, TensorFlow.TFDataType? dtype=null, string operName=null)
		{
			return graph.HistogramFixedWidth(values, value_range, nbins, dtype, operName);
		}
	}
}
