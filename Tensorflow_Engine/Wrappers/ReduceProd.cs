using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ReduceProd(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput? axis=null, System.Boolean? keep_dims=False, string operName=null)
		{
			return graph.ReduceProd(input, axis, keep_dims, operName);
		}
	}
}
