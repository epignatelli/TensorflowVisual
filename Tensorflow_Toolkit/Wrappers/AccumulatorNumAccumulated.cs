using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput AccumulatorNumAccumulated(TFGraph graph, TensorFlow.TFOutput handle, string operName=null)
		{
			return graph.AccumulatorNumAccumulated(handle, operName);
		}
	}
}
