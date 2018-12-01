using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput AccumulatorTakeGradient(this TFGraph graph, TensorFlow.TFOutput handle, TensorFlow.TFOutput num_required, TensorFlow.TFDataType dtype, string operName=null)
		{
			return graph.AccumulatorTakeGradient(handle, num_required, dtype, operName);
		}
	}
}
