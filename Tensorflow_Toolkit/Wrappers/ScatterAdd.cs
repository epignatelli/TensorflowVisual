using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ScatterAdd(TFGraph graph, TensorFlow.TFOutput reference, TensorFlow.TFOutput indices, TensorFlow.TFOutput updates, System.Boolean? use_locking=null, string operName=null)
		{
			return graph.ScatterAdd(reference, indices, updates, use_locking, operName);
		}
	}
}
