using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput AssignAdd(this TFGraph graph, TensorFlow.TFOutput reference, TensorFlow.TFOutput value, System.Boolean? use_locking=null, string operName=null)
		{
			return graph.AssignAdd(reference, value, use_locking, operName);
		}
	}
}
