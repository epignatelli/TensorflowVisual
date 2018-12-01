using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> SparseAccumulatorTakeGradient(this TFGraph graph, TensorFlow.TFOutput handle, TensorFlow.TFOutput num_required, TensorFlow.TFDataType dtype, string operName=null)
		{
			return graph.SparseAccumulatorTakeGradient(handle, num_required, dtype, operName);
		}
	}
}
