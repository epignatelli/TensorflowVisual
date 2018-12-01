using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Diag(TFGraph graph, TensorFlow.TFOutput diagonal, string operName=null)
		{
			return graph.Diag(diagonal, operName);
		}
	}
}
