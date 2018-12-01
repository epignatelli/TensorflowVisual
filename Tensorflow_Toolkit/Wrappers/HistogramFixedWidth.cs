using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput HistogramFixedWidth(TFGraph graph, TensorFlow.TFOutput values, TensorFlow.TFOutput value_range, TensorFlow.TFOutput nbins, TensorFlow.TFDataType? dtype=null, string operName=null)
		{
			return graph.HistogramFixedWidth(values, value_range, nbins, dtype, operName);
		}
	}
}
