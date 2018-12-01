using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput IsVariableInitialized(TFGraph graph, TensorFlow.TFOutput reference, string operName=null)
		{
			return graph.IsVariableInitialized(reference, operName);
		}
	}
}
