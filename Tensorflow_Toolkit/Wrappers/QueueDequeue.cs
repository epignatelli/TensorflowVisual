using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput[] QueueDequeue(TFGraph graph, TensorFlow.TFOutput handle, TensorFlow.TFDataType[] component_types, long? timeout_ms=null, string operName=null)
		{
			return graph.QueueDequeue(handle, component_types, timeout_ms, operName);
		}
	}
}
