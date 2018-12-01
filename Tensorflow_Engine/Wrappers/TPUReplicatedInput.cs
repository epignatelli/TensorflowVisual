using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TPUReplicatedInput(this TFGraph graph, TensorFlow.TFOutput[] inputs, string operName=null)
		{
			return graph.TPUReplicatedInput(inputs, operName);
		}
	}
}
