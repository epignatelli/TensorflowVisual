using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ScatterNdNonAliasingAdd(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput indices, TensorFlow.TFOutput updates, string operName=null)
		{
			return graph.ScatterNdNonAliasingAdd(input, indices, updates, operName);
		}
	}
}
