using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> QuantizedBiasAdd(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput bias, TensorFlow.TFOutput min_input, TensorFlow.TFOutput max_input, TensorFlow.TFOutput min_bias, TensorFlow.TFOutput max_bias, TensorFlow.TFDataType out_type, string operName=null)
		{
			return graph.QuantizedBiasAdd(input, bias, min_input, max_input, min_bias, max_bias, out_type, operName);
		}
	}
}
