using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation TPUEmbeddingSendGradients(TFGraph graph, TensorFlow.TFOutput[] gradients, string tpu_embedding_config, string operName=null)
		{
			return graph.TPUEmbeddingSendGradients(gradients, tpu_embedding_config, operName);
		}
	}
}
