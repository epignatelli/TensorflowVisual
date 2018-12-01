using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ScatterUpdate(TFGraph graph, TensorFlow.TFOutput reference, TensorFlow.TFOutput indices, TensorFlow.TFOutput updates, System.Boolean? use_locking=null, string operName=null)
		{
			return graph.ScatterUpdate(reference, indices, updates, use_locking, operName);
		}
	}
}
