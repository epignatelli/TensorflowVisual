using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> SparseSoftmaxCrossEntropyWithLogits(TFGraph graph, TensorFlow.TFOutput features, TensorFlow.TFOutput labels, string operName=null)
		{
			return graph.SparseSoftmaxCrossEntropyWithLogits(features, labels, operName);
		}
	}
}
