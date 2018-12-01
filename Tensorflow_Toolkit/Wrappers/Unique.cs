using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> Unique(TFGraph graph, TensorFlow.TFOutput x, TensorFlow.TFDataType? out_idx=null, string operName=null)
		{
			return graph.Unique(x, out_idx, operName);
		}
	}
}
