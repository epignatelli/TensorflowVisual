using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput CholeskyGrad(this TFGraph graph, TensorFlow.TFOutput l, TensorFlow.TFOutput grad, string operName=null)
		{
			return graph.CholeskyGrad(l, grad, operName);
		}
	}
}
