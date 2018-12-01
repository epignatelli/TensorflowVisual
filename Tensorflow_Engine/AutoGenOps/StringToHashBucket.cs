using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput StringToHashBucket(this TFGraph graph, TensorFlow.TFOutput string_tensor, long num_buckets, string operName=null)
		{
			return graph.StringToHashBucket(string_tensor, num_buckets, operName);
		}
	}
}
