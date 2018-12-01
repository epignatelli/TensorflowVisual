using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Betainc(TFGraph graph, TensorFlow.TFOutput a, TensorFlow.TFOutput b, TensorFlow.TFOutput x, string operName=null)
		{
			return graph.Betainc(a, b, x, operName);
		}
	}
}
