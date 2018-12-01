using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation AccumulatorApplyGradient(TFGraph graph, TensorFlow.TFOutput handle, TensorFlow.TFOutput local_step, TensorFlow.TFOutput gradient, string operName=null)
		{
			return graph.AccumulatorApplyGradient(handle, local_step, gradient, operName);
		}
	}
}
