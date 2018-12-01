using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput StringToHashBucketStrong(TFGraph graph, TensorFlow.TFOutput input, long num_buckets, long[] key, string operName=null)
		{
			return graph.StringToHashBucketStrong(input, num_buckets, key, operName);
		}
	}
}
