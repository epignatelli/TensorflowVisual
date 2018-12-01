using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput QuantizeAndDequantize(TFGraph graph, TensorFlow.TFOutput input, System.Boolean? signed_input=null, long? num_bits=null, System.Boolean? range_given=null, System.Single? input_min=null, System.Single? input_max=null, string operName=null)
		{
			return graph.QuantizeAndDequantize(input, signed_input, num_bits, range_given, input_min, input_max, operName);
		}
	}
}
