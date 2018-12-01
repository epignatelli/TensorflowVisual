using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput StringToHashBucketFast(TFGraph graph, TensorFlow.TFOutput input, long num_buckets, string operName=null)
		{
			return graph.StringToHashBucketFast(input, num_buckets, operName);
		}
	}
}
