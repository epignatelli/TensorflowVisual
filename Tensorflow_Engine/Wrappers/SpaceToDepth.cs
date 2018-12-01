using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SpaceToDepth(this TFGraph graph, TensorFlow.TFOutput input, long block_size, string data_format=null, string operName=null)
		{
			return graph.SpaceToDepth(input, block_size, data_format, operName);
		}
	}
}
