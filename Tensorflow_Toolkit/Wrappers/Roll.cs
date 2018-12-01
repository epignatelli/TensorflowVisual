using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Roll(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput shift, TensorFlow.TFOutput axis, string operName=null)
		{
			return graph.Roll(input, shift, axis, operName);
		}
	}
}
