using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput StatsAggregatorSummary(TFGraph graph, TensorFlow.TFOutput iterator, string operName=null)
		{
			return graph.StatsAggregatorSummary(iterator, operName);
		}
	}
}
