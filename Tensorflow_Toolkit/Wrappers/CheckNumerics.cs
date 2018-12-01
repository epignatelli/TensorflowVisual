using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput CheckNumerics(TFGraph graph, TensorFlow.TFOutput tensor, string message, string operName=null)
		{
			return graph.CheckNumerics(tensor, message, operName);
		}
	}
}
