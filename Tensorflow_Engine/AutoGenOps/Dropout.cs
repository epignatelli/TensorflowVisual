using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Dropout(this TFGraph graph, TensorFlow.TFOutput x, double keep_prob, TensorFlow.TFShape noise_shape=null, int? seed=null, string operName=null)
		{
			return graph.Dropout(x, keep_prob, noise_shape, seed, operName);
		}
	}
}
