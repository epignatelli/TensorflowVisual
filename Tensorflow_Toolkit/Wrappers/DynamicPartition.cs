using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput[] DynamicPartition(TFGraph graph, TensorFlow.TFOutput data, TensorFlow.TFOutput partitions, long num_partitions, string operName=null)
		{
			return graph.DynamicPartition(data, partitions, num_partitions, operName);
		}
	}
}
