using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static System.Boolean TryEvaluateConstant(this TFGraph graph, TensorFlow.TFOutput output, TensorFlow.TFTensor& tensor)
		{
			return graph.TryEvaluateConstant(output, tensor);
		}
	}
}
