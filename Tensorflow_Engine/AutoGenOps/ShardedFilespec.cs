using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ShardedFilespec(this TFGraph graph, TensorFlow.TFOutput basename, TensorFlow.TFOutput num_shards, string operName=null)
		{
			return graph.ShardedFilespec(basename, num_shards, operName);
		}
	}
}
