using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ShardedFilespec(TFGraph graph, TensorFlow.TFOutput basename, TensorFlow.TFOutput num_shards, string operName=null)
		{
			return graph.ShardedFilespec(basename, num_shards, operName);
		}
	}
}
