using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput GetSessionHandle(TFGraph graph, TensorFlow.TFOutput value, string operName=null)
		{
			return graph.GetSessionHandle(value, operName);
		}
	}
}
