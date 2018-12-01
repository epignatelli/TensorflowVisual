using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Dropout(TFGraph graph, TensorFlow.TFOutput x, double keep_prob, TensorFlow.TFShape noise_shape=null, int? seed=null, string operName=null)
		{
			return graph.Dropout(x, keep_prob, noise_shape, seed, operName);
		}
	}
}
