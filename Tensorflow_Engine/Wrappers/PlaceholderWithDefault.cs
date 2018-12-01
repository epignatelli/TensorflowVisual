using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput PlaceholderWithDefault(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFShape shape, string operName=null)
		{
			return graph.PlaceholderWithDefault(input, shape, operName);
		}
	}
}
