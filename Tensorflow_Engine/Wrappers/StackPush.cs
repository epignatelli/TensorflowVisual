using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput StackPush(this TFGraph graph, TensorFlow.TFOutput handle, TensorFlow.TFOutput elem, System.Boolean? swap_memory=null, string operName=null)
		{
			return graph.StackPush(handle, elem, swap_memory, operName);
		}
	}
}
