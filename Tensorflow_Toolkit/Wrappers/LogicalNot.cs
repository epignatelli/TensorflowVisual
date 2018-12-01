using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput LogicalNot(TFGraph graph, TensorFlow.TFOutput x, string operName=null)
		{
			return graph.LogicalNot(x, operName);
		}
	}
}
