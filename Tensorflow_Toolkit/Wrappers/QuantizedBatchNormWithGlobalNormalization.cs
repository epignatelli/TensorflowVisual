using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> QuantizedBatchNormWithGlobalNormalization(TFGraph graph, TensorFlow.TFOutput t, TensorFlow.TFOutput t_min, TensorFlow.TFOutput t_max, TensorFlow.TFOutput m, TensorFlow.TFOutput m_min, TensorFlow.TFOutput m_max, TensorFlow.TFOutput v, TensorFlow.TFOutput v_min, TensorFlow.TFOutput v_max, TensorFlow.TFOutput beta, TensorFlow.TFOutput beta_min, TensorFlow.TFOutput beta_max, TensorFlow.TFOutput gamma, TensorFlow.TFOutput gamma_min, TensorFlow.TFOutput gamma_max, TensorFlow.TFDataType out_type, System.Single variance_epsilon, System.Boolean scale_after_normalization, string operName=null)
		{
			return graph.QuantizedBatchNormWithGlobalNormalization(t, t_min, t_max, m, m_min, m_max, v, v_min, v_max, beta, beta_min, beta_max, gamma, gamma_min, gamma_max, out_type, variance_epsilon, scale_after_normalization, operName);
		}
	}
}
