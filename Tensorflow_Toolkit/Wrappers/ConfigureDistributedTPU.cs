using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ConfigureDistributedTPU(TFGraph graph, string embedding_config=null, string tpu_embedding_config=null, System.Boolean? is_global_init=null, string operName=null)
		{
			return graph.ConfigureDistributedTPU(embedding_config, tpu_embedding_config, is_global_init, operName);
		}
	}
}
