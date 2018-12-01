using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput MatrixSolve(this TFGraph graph, TensorFlow.TFOutput matrix, TensorFlow.TFOutput rhs, System.Boolean? adjoint=null, string operName=null)
		{
			return graph.MatrixSolve(matrix, rhs, adjoint, operName);
		}
	}
}
