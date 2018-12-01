using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation GcsConfigureBlockCache(TFGraph graph, TensorFlow.TFOutput max_cache_size, TensorFlow.TFOutput block_size, TensorFlow.TFOutput max_staleness, string operName=null)
		{
			return graph.GcsConfigureBlockCache(max_cache_size, block_size, max_staleness, operName);
		}
	}
}
