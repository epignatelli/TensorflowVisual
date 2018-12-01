using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> QuantizedReshape(TFGraph graph, TensorFlow.TFOutput tensor, TensorFlow.TFOutput shape, TensorFlow.TFOutput input_min, TensorFlow.TFOutput input_max, string operName=null)
		{
			return graph.QuantizedReshape(tensor, shape, input_min, input_max, operName);
		}
	}
}
