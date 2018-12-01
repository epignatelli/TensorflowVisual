using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput QueueSize(this TFGraph graph, TensorFlow.TFOutput handle, string operName=null)
		{
			return graph.QueueSize(handle, operName);
		}
	}
}
