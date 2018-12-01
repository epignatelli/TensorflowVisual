using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> TPUEmbeddingRetrieveAdagradParameters(this TFGraph graph, string tpu_embedding_config, long table_id, long num_hosts, long host_id, string operName=null)
		{
			return graph.TPUEmbeddingRetrieveAdagradParameters(tpu_embedding_config, table_id, num_hosts, host_id, operName);
		}
	}
}
