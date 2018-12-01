using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput BarrierIncompleteSize(TFGraph graph, TensorFlow.TFOutput handle, string operName=null)
		{
			return graph.BarrierIncompleteSize(handle, operName);
		}
	}
}