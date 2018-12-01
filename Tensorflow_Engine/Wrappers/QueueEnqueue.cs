using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation QueueEnqueue(this TFGraph graph, TensorFlow.TFOutput handle, TensorFlow.TFOutput[] components, long? timeout_ms=null, string operName=null)
		{
			return graph.QueueEnqueue(handle, components, timeout_ms, operName);
		}
	}
}
