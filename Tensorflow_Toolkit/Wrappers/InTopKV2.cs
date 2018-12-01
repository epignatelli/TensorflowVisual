using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput InTopKV2(TFGraph graph, TensorFlow.TFOutput predictions, TensorFlow.TFOutput targets, TensorFlow.TFOutput k, string operName=null)
		{
			return graph.InTopKV2(predictions, targets, k, operName);
		}
	}
}
