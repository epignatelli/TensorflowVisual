using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Cos(TFGraph graph, TensorFlow.TFOutput x, string operName=null)
		{
			return graph.Cos(x, operName);
		}
	}
}
