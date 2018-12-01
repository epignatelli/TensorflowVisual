using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Assign(this TFGraph graph, TensorFlow.TFOutput reference, TensorFlow.TFOutput value, System.Boolean? validate_shape=null, System.Boolean? use_locking=null, string operName=null)
		{
			return graph.Assign(reference, value, validate_shape, use_locking, operName);
		}
	}
}
