using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ConfigureDistributedTPU(this TFGraph graph, string embedding_config=null, string tpu_embedding_config=null, System.Boolean? is_global_init=null, string operName=null)
		{
			return graph.ConfigureDistributedTPU(embedding_config, tpu_embedding_config, is_global_init, operName);
		}
	}
}
