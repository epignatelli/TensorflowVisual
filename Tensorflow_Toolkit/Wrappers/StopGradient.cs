using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput StopGradient(TFGraph graph, TensorFlow.TFOutput input, string operName=null)
		{
			return graph.StopGradient(input, operName);
		}
	}
}
