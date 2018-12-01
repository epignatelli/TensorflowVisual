using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> Requantize(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput input_min, TensorFlow.TFOutput input_max, TensorFlow.TFOutput requested_output_min, TensorFlow.TFOutput requested_output_max, TensorFlow.TFDataType out_type, string operName=null)
		{
			return graph.Requantize(input, input_min, input_max, requested_output_min, requested_output_max, out_type, operName);
		}
	}
}
