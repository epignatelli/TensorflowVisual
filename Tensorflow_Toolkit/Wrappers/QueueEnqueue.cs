using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation QueueEnqueue(TFGraph graph, TensorFlow.TFOutput handle, TensorFlow.TFOutput[] components, long? timeout_ms=null, string operName=null)
		{
			return graph.QueueEnqueue(handle, components, timeout_ms, operName);
		}
	}
}
