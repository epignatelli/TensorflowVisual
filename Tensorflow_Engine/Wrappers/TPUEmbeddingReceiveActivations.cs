using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput[] TPUEmbeddingReceiveActivations(this TFGraph graph, long num_tables, string tpu_embedding_config, string operName=null)
		{
			return graph.TPUEmbeddingReceiveActivations(num_tables, tpu_embedding_config, operName);
		}
	}
}
