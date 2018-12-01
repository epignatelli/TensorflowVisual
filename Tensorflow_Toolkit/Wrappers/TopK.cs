using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> TopK(TFGraph graph, TensorFlow.TFOutput input, long k, System.Boolean? sorted=null, string operName=null)
		{
			return graph.TopK(input, k, sorted, operName);
		}
	}
}
