using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Squeeze(TFGraph graph, TensorFlow.TFOutput input, long[] squeeze_dims=null, string operName=null)
		{
			return graph.Squeeze(input, squeeze_dims, operName);
		}
	}
}
