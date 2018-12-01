using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation StackClose(TFGraph graph, TensorFlow.TFOutput handle, string operName=null)
		{
			return graph.StackClose(handle, operName);
		}
	}
}
