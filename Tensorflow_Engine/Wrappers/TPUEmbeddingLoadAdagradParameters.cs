using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation TPUEmbeddingLoadAdagradParameters(this TFGraph graph, TensorFlow.TFOutput parameters, TensorFlow.TFOutput accumulators, string tpu_embedding_config, long table_id, long num_hosts, long host_id, string operName=null)
		{
			return graph.TPUEmbeddingLoadAdagradParameters(parameters, accumulators, tpu_embedding_config, table_id, num_hosts, host_id, operName);
		}
	}
}
