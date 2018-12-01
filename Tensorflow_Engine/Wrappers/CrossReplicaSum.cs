using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput CrossReplicaSum(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput group_assignment, string operName=null)
		{
			return graph.CrossReplicaSum(input, group_assignment, operName);
		}
	}
}
