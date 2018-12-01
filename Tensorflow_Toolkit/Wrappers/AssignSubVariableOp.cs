using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation AssignSubVariableOp(TFGraph graph, TensorFlow.TFOutput resource, TensorFlow.TFOutput value, string operName=null)
		{
			return graph.AssignSubVariableOp(resource, value, operName);
		}
	}
}
