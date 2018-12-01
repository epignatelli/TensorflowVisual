using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput PreventGradient(TFGraph graph, TensorFlow.TFOutput input, string message=null, string operName=null)
		{
			return graph.PreventGradient(input, message, operName);
		}
	}
}
