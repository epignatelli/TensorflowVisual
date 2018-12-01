using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Assign(TFGraph graph, TensorFlow.TFOutput reference, TensorFlow.TFOutput value, System.Boolean? validate_shape=null, System.Boolean? use_locking=null, string operName=null)
		{
			return graph.Assign(reference, value, validate_shape, use_locking, operName);
		}
	}
}
