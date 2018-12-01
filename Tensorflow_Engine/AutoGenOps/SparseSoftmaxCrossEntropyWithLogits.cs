using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> SparseSoftmaxCrossEntropyWithLogits(this TFGraph graph, TensorFlow.TFOutput features, TensorFlow.TFOutput labels, string operName=null)
		{
			return graph.SparseSoftmaxCrossEntropyWithLogits(features, labels, operName);
		}
	}
}
