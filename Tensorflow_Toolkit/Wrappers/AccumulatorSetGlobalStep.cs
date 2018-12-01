using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation AccumulatorSetGlobalStep(TFGraph graph, TensorFlow.TFOutput handle, TensorFlow.TFOutput new_global_step, string operName=null)
		{
			return graph.AccumulatorSetGlobalStep(handle, new_global_step, operName);
		}
	}
}
