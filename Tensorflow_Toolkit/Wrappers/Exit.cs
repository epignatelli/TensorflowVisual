using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Exit(TFGraph graph, TensorFlow.TFOutput data, string operName=null)
		{
			return graph.Exit(data, operName);
		}
	}
}
