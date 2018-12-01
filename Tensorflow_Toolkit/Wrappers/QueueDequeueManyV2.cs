using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput[] QueueDequeueManyV2(TFGraph graph, TensorFlow.TFOutput handle, TensorFlow.TFOutput n, TensorFlow.TFDataType[] component_types, long? timeout_ms=null, string operName=null)
		{
			return graph.QueueDequeueManyV2(handle, n, component_types, timeout_ms, operName);
		}
	}
}
