using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput AddN(TFGraph graph, TensorFlow.TFOutput[] inputs, string operName=null)
		{
			return graph.AddN(inputs, operName);
		}
	}
}
