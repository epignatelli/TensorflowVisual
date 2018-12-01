using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Cross(TFGraph graph, TensorFlow.TFOutput a, TensorFlow.TFOutput b, string operName=null)
		{
			return graph.Cross(a, b, operName);
		}
	}
}
