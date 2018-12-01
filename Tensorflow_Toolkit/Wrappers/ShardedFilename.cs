using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ShardedFilename(TFGraph graph, TensorFlow.TFOutput basename, TensorFlow.TFOutput shard, TensorFlow.TFOutput num_shards, string operName=null)
		{
			return graph.ShardedFilename(basename, shard, num_shards, operName);
		}
	}
}
