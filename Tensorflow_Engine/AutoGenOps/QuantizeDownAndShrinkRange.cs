using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> QuantizeDownAndShrinkRange(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput input_min, TensorFlow.TFOutput input_max, TensorFlow.TFDataType out_type, string operName=null)
		{
			return graph.QuantizeDownAndShrinkRange(input, input_min, input_max, out_type, operName);
		}
	}
}
