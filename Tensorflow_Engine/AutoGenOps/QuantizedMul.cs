using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> QuantizedMul(this TFGraph graph, TensorFlow.TFOutput x, TensorFlow.TFOutput y, TensorFlow.TFOutput min_x, TensorFlow.TFOutput max_x, TensorFlow.TFOutput min_y, TensorFlow.TFOutput max_y, TensorFlow.TFDataType? Toutput=null, string operName=null)
		{
			return graph.QuantizedMul(x, y, min_x, max_x, min_y, max_y, Toutput, operName);
		}
	}
}
