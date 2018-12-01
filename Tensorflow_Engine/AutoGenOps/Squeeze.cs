using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Squeeze(this TFGraph graph, TensorFlow.TFOutput input, long[] squeeze_dims=null, string operName=null)
		{
			return graph.Squeeze(input, squeeze_dims, operName);
		}
	}
}
