using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Relu6Grad(TFGraph graph, TensorFlow.TFOutput gradients, TensorFlow.TFOutput features, string operName=null)
		{
			return graph.Relu6Grad(gradients, features, operName);
		}
	}
}
