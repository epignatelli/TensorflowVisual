using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SigmoidGrad(TFGraph graph, TensorFlow.TFOutput y, TensorFlow.TFOutput dy, string operName=null)
		{
			return graph.SigmoidGrad(y, dy, operName);
		}
	}
}
