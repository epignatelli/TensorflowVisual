using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> Svd(TFGraph graph, TensorFlow.TFOutput input, System.Boolean? compute_uv=null, System.Boolean? full_matrices=null, string operName=null)
		{
			return graph.Svd(input, compute_uv, full_matrices, operName);
		}
	}
}
