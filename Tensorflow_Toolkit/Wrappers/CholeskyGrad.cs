using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput CholeskyGrad(TFGraph graph, TensorFlow.TFOutput l, TensorFlow.TFOutput grad, string operName=null)
		{
			return graph.CholeskyGrad(l, grad, operName);
		}
	}
}
