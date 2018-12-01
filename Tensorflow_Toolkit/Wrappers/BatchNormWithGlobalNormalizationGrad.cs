using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> BatchNormWithGlobalNormalizationGrad(TFGraph graph, TensorFlow.TFOutput t, TensorFlow.TFOutput m, TensorFlow.TFOutput v, TensorFlow.TFOutput gamma, TensorFlow.TFOutput backprop, System.Single variance_epsilon, System.Boolean scale_after_normalization, string operName=null)
		{
			return graph.BatchNormWithGlobalNormalizationGrad(t, m, v, gamma, backprop, variance_epsilon, scale_after_normalization, operName);
		}
	}
}
