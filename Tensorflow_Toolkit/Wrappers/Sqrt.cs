using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Sqrt(TFGraph graph, TensorFlow.TFOutput x, string operName=null)
		{
			return graph.Sqrt(x, operName);
		}
	}
}
