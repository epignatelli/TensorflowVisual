using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput GatherNd(TFGraph graph, TensorFlow.TFOutput parameters, TensorFlow.TFOutput indices, string operName=null)
		{
			return graph.GatherNd(parameters, indices, operName);
		}
	}
}
