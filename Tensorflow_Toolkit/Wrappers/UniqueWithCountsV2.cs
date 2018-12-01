using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> UniqueWithCountsV2(TFGraph graph, TensorFlow.TFOutput x, TensorFlow.TFOutput axis, TensorFlow.TFDataType? out_idx=null, string operName=null)
		{
			return graph.UniqueWithCountsV2(x, axis, out_idx, operName);
		}
	}
}
