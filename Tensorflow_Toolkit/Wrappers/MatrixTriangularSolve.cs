using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput MatrixTriangularSolve(TFGraph graph, TensorFlow.TFOutput matrix, TensorFlow.TFOutput rhs, System.Boolean? lower=null, System.Boolean? adjoint=null, string operName=null)
		{
			return graph.MatrixTriangularSolve(matrix, rhs, lower, adjoint, operName);
		}
	}
}
