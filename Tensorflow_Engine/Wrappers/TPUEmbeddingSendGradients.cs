using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation TPUEmbeddingSendGradients(this TFGraph graph, TensorFlow.TFOutput[] gradients, string tpu_embedding_config, string operName=null)
		{
			return graph.TPUEmbeddingSendGradients(gradients, tpu_embedding_config, operName);
		}
	}
}
