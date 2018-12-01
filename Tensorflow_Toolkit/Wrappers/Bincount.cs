using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Bincount(TFGraph graph, TensorFlow.TFOutput arr, TensorFlow.TFOutput size, TensorFlow.TFOutput weights, string operName=null)
		{
			return graph.Bincount(arr, size, weights, operName);
		}
	}
}
