using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput DepthToSpace(TFGraph graph, TensorFlow.TFOutput input, long block_size, string data_format=null, string operName=null)
		{
			return graph.DepthToSpace(input, block_size, data_format, operName);
		}
	}
}