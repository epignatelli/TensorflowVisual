using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput[]> BarrierTakeMany(this TFGraph graph, TensorFlow.TFOutput handle, TensorFlow.TFOutput num_elements, TensorFlow.TFDataType[] component_types, System.Boolean? allow_small_batch=null, System.Boolean? wait_for_incomplete=null, long? timeout_ms=null, string operName=null)
		{
			return graph.BarrierTakeMany(handle, num_elements, component_types, allow_small_batch, wait_for_incomplete, timeout_ms, operName);
		}
	}
}
