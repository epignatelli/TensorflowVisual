using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput RsqrtGrad(TFGraph graph, TensorFlow.TFOutput y, TensorFlow.TFOutput dy, string operName=null)
		{
			return graph.RsqrtGrad(y, dy, operName);
		}
	}
}
