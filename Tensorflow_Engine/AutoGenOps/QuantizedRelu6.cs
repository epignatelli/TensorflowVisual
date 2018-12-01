using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> QuantizedRelu6(this TFGraph graph, TensorFlow.TFOutput features, TensorFlow.TFOutput min_features, TensorFlow.TFOutput max_features, TensorFlow.TFDataType? out_type=null, string operName=null)
		{
			return graph.QuantizedRelu6(features, min_features, max_features, out_type, operName);
		}
	}
}
