using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static System.Boolean TryEvaluateConstant(this TFGraph graph, TensorFlow.TFOutput output, ref TFTensor tensor)
		{
			return graph.TryEvaluateConstant(output, ref tensor);
		}
	}
}
