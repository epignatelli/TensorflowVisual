using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput HistogramSummary(TFGraph graph, TensorFlow.TFOutput tag, TensorFlow.TFOutput values, string operName=null)
		{
			return graph.HistogramSummary(tag, values, operName);
		}
	}
}
