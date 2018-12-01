using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput BatchNormWithGlobalNormalization(TFGraph graph, TensorFlow.TFOutput t, TensorFlow.TFOutput m, TensorFlow.TFOutput v, TensorFlow.TFOutput beta, TensorFlow.TFOutput gamma, System.Single variance_epsilon, System.Boolean scale_after_normalization, string operName=null)
		{
			return graph.BatchNormWithGlobalNormalization(t, m, v, beta, gamma, variance_epsilon, scale_after_normalization, operName);
		}
	}
}
