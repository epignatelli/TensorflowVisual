using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation QueueCloseV2(TFGraph graph, TensorFlow.TFOutput handle, System.Boolean? cancel_pending_enqueues=null, string operName=null)
		{
			return graph.QueueCloseV2(handle, cancel_pending_enqueues, operName);
		}
	}
}
