using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput[] QueueDequeue(this TFGraph graph, TensorFlow.TFOutput handle, TensorFlow.TFDataType[] component_types, long? timeout_ms=null, string operName=null)
		{
			return graph.QueueDequeue(handle, component_types, timeout_ms, operName);
		}
	}
}
