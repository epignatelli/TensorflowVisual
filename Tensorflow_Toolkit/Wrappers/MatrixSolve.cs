using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput MatrixSolve(TFGraph graph, TensorFlow.TFOutput matrix, TensorFlow.TFOutput rhs, System.Boolean? adjoint=null, string operName=null)
		{
			return graph.MatrixSolve(matrix, rhs, adjoint, operName);
		}
	}
}
