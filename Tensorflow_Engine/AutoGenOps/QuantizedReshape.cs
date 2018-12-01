using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> QuantizedReshape(this TFGraph graph, TensorFlow.TFOutput tensor, TensorFlow.TFOutput shape, TensorFlow.TFOutput input_min, TensorFlow.TFOutput input_max, string operName=null)
		{
			return graph.QuantizedReshape(tensor, shape, input_min, input_max, operName);
		}
	}
}
