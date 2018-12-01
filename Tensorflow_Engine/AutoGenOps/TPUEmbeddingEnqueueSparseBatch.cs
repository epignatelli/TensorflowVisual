using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation TPUEmbeddingEnqueueSparseBatch(this TFGraph graph, TensorFlow.TFOutput[] sample_indices, TensorFlow.TFOutput[] embedding_indices, TensorFlow.TFOutput[] aggregation_weights, long? device_ordinal=null, string operName=null)
		{
			return graph.TPUEmbeddingEnqueueSparseBatch(sample_indices, embedding_indices, aggregation_weights, device_ordinal, operName);
		}
	}
}
