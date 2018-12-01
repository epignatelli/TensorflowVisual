using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> TopK(this TFGraph graph, TensorFlow.TFOutput input, long k, System.Boolean? sorted=null, string operName=null)
		{
			return graph.TopK(input, k, sorted, operName);
		}
	}
}
