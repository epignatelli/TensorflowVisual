using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation AccumulatorApplyGradient(this TFGraph graph, TensorFlow.TFOutput handle, TensorFlow.TFOutput local_step, TensorFlow.TFOutput gradient, string operName=null)
		{
			return graph.AccumulatorApplyGradient(handle, local_step, gradient, operName);
		}
	}
}
