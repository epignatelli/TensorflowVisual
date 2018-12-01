using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput QueueIsClosedV2(this TFGraph graph, TensorFlow.TFOutput handle, string operName=null)
		{
			return graph.QueueIsClosedV2(handle, operName);
		}
	}
}
