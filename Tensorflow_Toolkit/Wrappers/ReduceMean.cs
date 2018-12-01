using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ReduceMean(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput? axis=null, System.Boolean? keep_dims=False, string operName=null)
		{
			return graph.ReduceMean(input, axis, keep_dims, operName);
		}
	}
}
