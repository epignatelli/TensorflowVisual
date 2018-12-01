using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> TopKV2(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput k, System.Boolean? sorted=null, string operName=null)
		{
			return graph.TopKV2(input, k, sorted, operName);
		}
	}
}
