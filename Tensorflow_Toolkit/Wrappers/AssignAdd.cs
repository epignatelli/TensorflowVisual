using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput AssignAdd(TFGraph graph, TensorFlow.TFOutput reference, TensorFlow.TFOutput value, System.Boolean? use_locking=null, string operName=null)
		{
			return graph.AssignAdd(reference, value, use_locking, operName);
		}
	}
}
