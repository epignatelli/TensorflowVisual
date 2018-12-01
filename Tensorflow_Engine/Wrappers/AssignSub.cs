using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput AssignSub(this TFGraph graph, TensorFlow.TFOutput reference, TensorFlow.TFOutput value, System.Boolean? use_locking=null, string operName=null)
		{
			return graph.AssignSub(reference, value, use_locking, operName);
		}
	}
}
