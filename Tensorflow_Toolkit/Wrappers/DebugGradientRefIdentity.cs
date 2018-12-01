using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput DebugGradientRefIdentity(TFGraph graph, TensorFlow.TFOutput input, string operName=null)
		{
			return graph.DebugGradientRefIdentity(input, operName);
		}
	}
}