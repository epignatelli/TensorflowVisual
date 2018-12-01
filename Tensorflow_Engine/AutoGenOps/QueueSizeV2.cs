using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput QueueSizeV2(this TFGraph graph, TensorFlow.TFOutput handle, string operName=null)
		{
			return graph.QueueSizeV2(handle, operName);
		}
	}
}
