using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput[] TPUReplicatedOutput(this TFGraph graph, TensorFlow.TFOutput input, long num_replicas, string operName=null)
		{
			return graph.TPUReplicatedOutput(input, num_replicas, operName);
		}
	}
}
