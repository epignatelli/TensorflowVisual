using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Tile(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput multiples, string operName=null)
		{
			return graph.Tile(input, multiples, operName);
		}
	}
}
