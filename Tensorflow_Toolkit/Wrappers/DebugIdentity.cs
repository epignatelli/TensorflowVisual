using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput DebugIdentity(TFGraph graph, TensorFlow.TFOutput input, string device_name=null, string tensor_name=null, string[] debug_urls=null, System.Boolean? gated_grpc=null, string operName=null)
		{
			return graph.DebugIdentity(input, device_name, tensor_name, debug_urls, gated_grpc, operName);
		}
	}
}
