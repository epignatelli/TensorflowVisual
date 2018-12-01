using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> FusedBatchNormGrad(this TFGraph graph, TensorFlow.TFOutput y_backprop, TensorFlow.TFOutput x, TensorFlow.TFOutput scale, TensorFlow.TFOutput reserve_space_1, TensorFlow.TFOutput reserve_space_2, System.Single? epsilon=null, string data_format=null, System.Boolean? is_training=null, string operName=null)
		{
			return graph.FusedBatchNormGrad(y_backprop, x, scale, reserve_space_1, reserve_space_2, epsilon, data_format, is_training, operName);
		}
	}
}
