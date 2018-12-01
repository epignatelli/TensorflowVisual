using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SigmoidCrossEntropyWithLogits(this TFGraph graph, TensorFlow.TFOutput labels, TensorFlow.TFOutput logits, string operName=null)
		{
			return graph.SigmoidCrossEntropyWithLogits(labels, logits, operName);
		}
	}
}
