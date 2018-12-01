using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> SoftmaxCrossEntropyWithLogits(this TFGraph graph, TensorFlow.TFOutput features, TensorFlow.TFOutput labels, string operName=null)
		{
			return graph.SoftmaxCrossEntropyWithLogits(features, labels, operName);
		}
	}
}
