using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Unbatch(this TFGraph graph, TensorFlow.TFOutput batched_tensor, TensorFlow.TFOutput batch_index, TensorFlow.TFOutput id, long timeout_micros, string container=null, string shared_name=null, string operName=null)
		{
			return graph.Unbatch(batched_tensor, batch_index, id, timeout_micros, container, shared_name, operName);
		}
	}
}
