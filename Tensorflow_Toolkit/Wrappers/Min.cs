using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Min(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput reduction_indices, System.Boolean? keep_dims=null, string operName=null)
		{
			return graph.Min(input, reduction_indices, keep_dims, operName);
		}
	}
}
