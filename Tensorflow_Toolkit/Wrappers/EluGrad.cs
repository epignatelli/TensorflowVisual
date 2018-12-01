using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput EluGrad(TFGraph graph, TensorFlow.TFOutput gradients, TensorFlow.TFOutput outputs, string operName=null)
		{
			return graph.EluGrad(gradients, outputs, operName);
		}
	}
}
