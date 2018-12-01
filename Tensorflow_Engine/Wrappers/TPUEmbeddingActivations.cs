using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TPUEmbeddingActivations(this TFGraph graph, TensorFlow.TFOutput embedding_variable, TensorFlow.TFOutput sliced_activations, long table_id, long lookup_id, string operName=null)
		{
			return graph.TPUEmbeddingActivations(embedding_variable, sliced_activations, table_id, lookup_id, operName);
		}
	}
}
