using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput InTopK(TFGraph graph, TensorFlow.TFOutput predictions, TensorFlow.TFOutput targets, long k, string operName=null)
		{
			return graph.InTopK(predictions, targets, k, operName);
		}
	}
}
