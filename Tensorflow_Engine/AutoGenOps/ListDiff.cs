using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> ListDiff(this TFGraph graph, TensorFlow.TFOutput x, TensorFlow.TFOutput y, TensorFlow.TFDataType? out_idx=null, string operName=null)
		{
			return graph.ListDiff(x, y, out_idx, operName);
		}
	}
}
