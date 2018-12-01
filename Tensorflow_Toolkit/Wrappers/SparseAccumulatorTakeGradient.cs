using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> SparseAccumulatorTakeGradient(TFGraph graph, TensorFlow.TFOutput handle, TensorFlow.TFOutput num_required, TensorFlow.TFDataType dtype, string operName=null)
		{
			return graph.SparseAccumulatorTakeGradient(handle, num_required, dtype, operName);
		}
	}
}
