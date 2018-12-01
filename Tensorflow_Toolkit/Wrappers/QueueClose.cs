using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation QueueClose(TFGraph graph, TensorFlow.TFOutput handle, System.Boolean? cancel_pending_enqueues=null, string operName=null)
		{
			return graph.QueueClose(handle, cancel_pending_enqueues, operName);
		}
	}
}
