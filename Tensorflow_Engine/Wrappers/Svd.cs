using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> Svd(this TFGraph graph, TensorFlow.TFOutput input, System.Boolean? compute_uv=null, System.Boolean? full_matrices=null, string operName=null)
		{
			return graph.Svd(input, compute_uv, full_matrices, operName);
		}
	}
}
