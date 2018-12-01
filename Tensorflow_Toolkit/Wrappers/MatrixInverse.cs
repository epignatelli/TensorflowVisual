using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput MatrixInverse(TFGraph graph, TensorFlow.TFOutput input, System.Boolean? adjoint=null, string operName=null)
		{
			return graph.MatrixInverse(input, adjoint, operName);
		}
	}
}
