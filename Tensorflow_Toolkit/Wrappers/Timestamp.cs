using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Timestamp(TFGraph graph, string operName=null)
		{
			return graph.Timestamp(operName);
		}
	}
}
