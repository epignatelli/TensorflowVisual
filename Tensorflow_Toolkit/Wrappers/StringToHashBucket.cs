using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput StringToHashBucket(TFGraph graph, TensorFlow.TFOutput string_tensor, long num_buckets, string operName=null)
		{
			return graph.StringToHashBucket(string_tensor, num_buckets, operName);
		}
	}
}
