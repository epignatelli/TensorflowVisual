using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> QuantizedConcat(this TFGraph graph, TensorFlow.TFOutput concat_dim, TensorFlow.TFOutput[] values, TensorFlow.TFOutput[] input_mins, TensorFlow.TFOutput[] input_maxes, string operName=null)
		{
			return graph.QuantizedConcat(concat_dim, values, input_mins, input_maxes, operName);
		}
	}
}
