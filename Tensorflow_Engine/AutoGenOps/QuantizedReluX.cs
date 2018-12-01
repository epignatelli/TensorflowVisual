using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> QuantizedReluX(this TFGraph graph, TensorFlow.TFOutput features, TensorFlow.TFOutput max_value, TensorFlow.TFOutput min_features, TensorFlow.TFOutput max_features, TensorFlow.TFDataType? out_type=null, string operName=null)
		{
			return graph.QuantizedReluX(features, max_value, min_features, max_features, out_type, operName);
		}
	}
}
