using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> UniqueV2(this TFGraph graph, TensorFlow.TFOutput x, TensorFlow.TFOutput axis, TensorFlow.TFDataType? out_idx=null, string operName=null)
		{
			return graph.UniqueV2(x, axis, out_idx, operName);
		}
	}
}
