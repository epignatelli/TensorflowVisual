using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation AssignVariableOp(TFGraph graph, TensorFlow.TFOutput resource, TensorFlow.TFOutput value, string operName=null)
		{
			return graph.AssignVariableOp(resource, value, operName);
		}
	}
}
