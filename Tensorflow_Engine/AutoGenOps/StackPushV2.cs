using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput StackPushV2(this TFGraph graph, TensorFlow.TFOutput handle, TensorFlow.TFOutput elem, System.Boolean? swap_memory=null, string operName=null)
		{
			return graph.StackPushV2(handle, elem, swap_memory, operName);
		}
	}
}
