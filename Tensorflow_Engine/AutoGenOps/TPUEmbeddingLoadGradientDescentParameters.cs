using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation TPUEmbeddingLoadGradientDescentParameters(this TFGraph graph, TensorFlow.TFOutput parameters, string tpu_embedding_config, long table_id, long num_hosts, long host_id, string operName=null)
		{
			return graph.TPUEmbeddingLoadGradientDescentParameters(parameters, tpu_embedding_config, table_id, num_hosts, host_id, operName);
		}
	}
}
