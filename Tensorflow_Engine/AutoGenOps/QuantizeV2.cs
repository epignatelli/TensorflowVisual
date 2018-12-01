using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> QuantizeV2(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput min_range, TensorFlow.TFOutput max_range, TensorFlow.TFDataType T, string mode=null, string round_mode=null, string operName=null)
		{
			return graph.QuantizeV2(input, min_range, max_range, T, mode, round_mode, operName);
		}
	}
}
