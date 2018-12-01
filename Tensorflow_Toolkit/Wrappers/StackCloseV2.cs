using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation StackCloseV2(TFGraph graph, TensorFlow.TFOutput handle, string operName=null)
		{
			return graph.StackCloseV2(handle, operName);
		}
	}
}
