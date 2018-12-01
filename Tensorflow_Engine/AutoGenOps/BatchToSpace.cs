using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput BatchToSpace(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput crops, long block_size, string operName=null)
		{
			return graph.BatchToSpace(input, crops, block_size, operName);
		}
	}
}
