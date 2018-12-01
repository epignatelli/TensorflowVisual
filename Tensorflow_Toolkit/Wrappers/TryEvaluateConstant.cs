using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static System.Boolean TryEvaluateConstant(TFGraph graph, TensorFlow.TFOutput output, TensorFlow.TFTensor& tensor)
		{
			return graph.TryEvaluateConstant(output, tensor);
		}
	}
}
