using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput QueueIsClosed(TFGraph graph, TensorFlow.TFOutput handle, string operName=null)
		{
			return graph.QueueIsClosed(handle, operName);
		}
	}
}
