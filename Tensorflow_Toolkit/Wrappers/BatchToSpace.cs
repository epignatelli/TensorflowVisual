using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput BatchToSpace(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput crops, long block_size, string operName=null)
		{
			return graph.BatchToSpace(input, crops, block_size, operName);
		}
	}
}
