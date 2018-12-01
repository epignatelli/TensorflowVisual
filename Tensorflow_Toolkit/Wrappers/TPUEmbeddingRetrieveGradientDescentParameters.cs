using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TPUEmbeddingRetrieveGradientDescentParameters(TFGraph graph, string tpu_embedding_config, long table_id, long num_hosts, long host_id, string operName=null)
		{
			return graph.TPUEmbeddingRetrieveGradientDescentParameters(tpu_embedding_config, table_id, num_hosts, host_id, operName);
		}
	}
}
