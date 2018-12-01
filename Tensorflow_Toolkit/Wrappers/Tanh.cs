using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Tanh(TFGraph graph, TensorFlow.TFOutput x, string operName=null)
		{
			return graph.Tanh(x, operName);
		}
	}
}
