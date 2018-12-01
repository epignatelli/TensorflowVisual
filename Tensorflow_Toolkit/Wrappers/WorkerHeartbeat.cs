using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput WorkerHeartbeat(TFGraph graph, TensorFlow.TFOutput request, string operName=null)
		{
			return graph.WorkerHeartbeat(request, operName);
		}
	}
}
