using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput[] TPUReplicatedOutput(TFGraph graph, TensorFlow.TFOutput input, long num_replicas, string operName=null)
		{
			return graph.TPUReplicatedOutput(input, num_replicas, operName);
		}
	}
}
