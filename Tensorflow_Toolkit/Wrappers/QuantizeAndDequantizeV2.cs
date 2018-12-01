using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput QuantizeAndDequantizeV2(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput input_min, TensorFlow.TFOutput input_max, System.Boolean? signed_input=null, long? num_bits=null, System.Boolean? range_given=null, string operName=null)
		{
			return graph.QuantizeAndDequantizeV2(input, input_min, input_max, signed_input, num_bits, range_given, operName);
		}
	}
}
