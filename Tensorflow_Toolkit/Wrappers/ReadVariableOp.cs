using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ReadVariableOp(TFGraph graph, TensorFlow.TFOutput resource, TensorFlow.TFDataType dtype, string operName=null)
		{
			return graph.ReadVariableOp(resource, dtype, operName);
		}
	}
}
