using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput QuantizeAndDequantizeV3(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput input_min, TensorFlow.TFOutput input_max, TensorFlow.TFOutput num_bits, System.Boolean? signed_input=null, System.Boolean? range_given=null, string operName=null)
		{
			return graph.QuantizeAndDequantizeV3(input, input_min, input_max, num_bits, signed_input, range_given, operName);
		}
	}
}
