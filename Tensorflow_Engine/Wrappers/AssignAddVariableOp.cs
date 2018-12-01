using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation AssignAddVariableOp(this TFGraph graph, TensorFlow.TFOutput resource, TensorFlow.TFOutput value, string operName=null)
		{
			return graph.AssignAddVariableOp(resource, value, operName);
		}
	}
}
