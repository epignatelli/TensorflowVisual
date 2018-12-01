using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput[] DynamicPartition(this TFGraph graph, TensorFlow.TFOutput data, TensorFlow.TFOutput partitions, long num_partitions, string operName=null)
		{
			return graph.DynamicPartition(data, partitions, num_partitions, operName);
		}
	}
}
