using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput DebugNanCount(this TFGraph graph, TensorFlow.TFOutput input, string device_name=null, string tensor_name=null, string[] debug_urls=null, System.Boolean? gated_grpc=null, string operName=null)
		{
			return graph.DebugNanCount(input, device_name, tensor_name, debug_urls, gated_grpc, operName);
		}
	}
}
