using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput StringToHashBucketFast(this TFGraph graph, TensorFlow.TFOutput input, long num_buckets, string operName=null)
		{
			return graph.StringToHashBucketFast(input, num_buckets, operName);
		}
	}
}
