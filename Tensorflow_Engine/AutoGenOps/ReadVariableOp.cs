using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ReadVariableOp(this TFGraph graph, TensorFlow.TFOutput resource, TensorFlow.TFDataType dtype, string operName=null)
		{
			return graph.ReadVariableOp(resource, dtype, operName);
		}
	}
}
