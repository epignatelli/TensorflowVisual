using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput GetSessionHandleV2(TFGraph graph, TensorFlow.TFOutput value, string operName=null)
		{
			return graph.GetSessionHandleV2(value, operName);
		}
	}
}
