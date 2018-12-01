using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> SparseSlice(TFGraph graph, TensorFlow.TFOutput indices, TensorFlow.TFOutput values, TensorFlow.TFOutput shape, TensorFlow.TFOutput start, TensorFlow.TFOutput size, string operName=null)
		{
			return graph.SparseSlice(indices, values, shape, start, size, operName);
		}
	}
}
