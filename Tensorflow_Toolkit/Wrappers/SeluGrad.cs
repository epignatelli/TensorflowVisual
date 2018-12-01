using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SeluGrad(TFGraph graph, TensorFlow.TFOutput gradients, TensorFlow.TFOutput outputs, string operName=null)
		{
			return graph.SeluGrad(gradients, outputs, operName);
		}
	}
}
