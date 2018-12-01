using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SeluGrad(this TFGraph graph, TensorFlow.TFOutput gradients, TensorFlow.TFOutput outputs, string operName=null)
		{
			return graph.SeluGrad(gradients, outputs, operName);
		}
	}
}
