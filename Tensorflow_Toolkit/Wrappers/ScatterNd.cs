using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ScatterNd(TFGraph graph, TensorFlow.TFOutput indices, TensorFlow.TFOutput updates, TensorFlow.TFOutput shape, string operName=null)
		{
			return graph.ScatterNd(indices, updates, shape, operName);
		}
	}
}
