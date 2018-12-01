using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> UniqueWithCounts(this TFGraph graph, TensorFlow.TFOutput x, TensorFlow.TFDataType? out_idx=null, string operName=null)
		{
			return graph.UniqueWithCounts(x, out_idx, operName);
		}
	}
}
