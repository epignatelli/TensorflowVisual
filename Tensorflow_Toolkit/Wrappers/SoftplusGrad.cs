using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SoftplusGrad(TFGraph graph, TensorFlow.TFOutput gradients, TensorFlow.TFOutput features, string operName=null)
		{
			return graph.SoftplusGrad(gradients, features, operName);
		}
	}
}
