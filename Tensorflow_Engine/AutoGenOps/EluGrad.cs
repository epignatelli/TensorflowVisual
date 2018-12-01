using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput EluGrad(this TFGraph graph, TensorFlow.TFOutput gradients, TensorFlow.TFOutput outputs, string operName=null)
		{
			return graph.EluGrad(gradients, outputs, operName);
		}
	}
}
