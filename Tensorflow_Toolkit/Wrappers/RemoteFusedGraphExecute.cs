using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput[] RemoteFusedGraphExecute(TFGraph graph, TensorFlow.TFOutput[] inputs, TensorFlow.TFDataType[] Toutputs, string serialized_remote_fused_graph_execute_info, string operName=null)
		{
			return graph.RemoteFusedGraphExecute(inputs, Toutputs, serialized_remote_fused_graph_execute_info, operName);
		}
	}
}
