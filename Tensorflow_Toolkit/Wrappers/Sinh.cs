using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Sinh(TFGraph graph, TensorFlow.TFOutput x, string operName=null)
		{
			return graph.Sinh(x, operName);
		}
	}
}
