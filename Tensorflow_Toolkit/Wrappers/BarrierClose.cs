using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation BarrierClose(TFGraph graph, TensorFlow.TFOutput handle, System.Boolean? cancel_pending_enqueues=null, string operName=null)
		{
			return graph.BarrierClose(handle, cancel_pending_enqueues, operName);
		}
	}
}
