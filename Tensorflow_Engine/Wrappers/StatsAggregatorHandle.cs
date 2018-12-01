using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput StatsAggregatorHandle(this TFGraph graph, string container=null, string shared_name=null, string operName=null)
		{
			return graph.StatsAggregatorHandle(container, shared_name, operName);
		}
	}
}
