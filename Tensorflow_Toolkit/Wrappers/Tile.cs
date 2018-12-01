using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Tile(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput multiples, string operName=null)
		{
			return graph.Tile(input, multiples, operName);
		}
	}
}
