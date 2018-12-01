using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput PlaceholderWithDefault(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFShape shape, string operName=null)
		{
			return graph.PlaceholderWithDefault(input, shape, operName);
		}
	}
}
