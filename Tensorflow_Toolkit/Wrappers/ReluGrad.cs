using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ReluGrad(TFGraph graph, TensorFlow.TFOutput gradients, TensorFlow.TFOutput features, string operName=null)
		{
			return graph.ReluGrad(gradients, features, operName);
		}
	}
}
