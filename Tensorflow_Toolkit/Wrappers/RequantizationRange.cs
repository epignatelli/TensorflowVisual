using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> RequantizationRange(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput input_min, TensorFlow.TFOutput input_max, string operName=null)
		{
			return graph.RequantizationRange(input, input_min, input_max, operName);
		}
	}
}
