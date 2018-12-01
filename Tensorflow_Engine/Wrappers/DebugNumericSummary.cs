using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput DebugNumericSummary(this TFGraph graph, TensorFlow.TFOutput input, string device_name=null, string tensor_name=null, string[] debug_urls=null, System.Single? lower_bound=null, System.Single? upper_bound=null, System.Boolean? mute_if_healthy=null, System.Boolean? gated_grpc=null, string operName=null)
		{
			return graph.DebugNumericSummary(input, device_name, tensor_name, debug_urls, lower_bound, upper_bound, mute_if_healthy, gated_grpc, operName);
		}
	}
}
