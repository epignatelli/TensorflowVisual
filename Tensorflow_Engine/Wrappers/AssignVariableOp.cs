using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation AssignVariableOp(this TFGraph graph, TensorFlow.TFOutput resource, TensorFlow.TFOutput value, string operName=null)
		{
			return graph.AssignVariableOp(resource, value, operName);
		}
	}
}
