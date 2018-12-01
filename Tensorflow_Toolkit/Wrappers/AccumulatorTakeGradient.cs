using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput AccumulatorTakeGradient(TFGraph graph, TensorFlow.TFOutput handle, TensorFlow.TFOutput num_required, TensorFlow.TFDataType dtype, string operName=null)
		{
			return graph.AccumulatorTakeGradient(handle, num_required, dtype, operName);
		}
	}
}
