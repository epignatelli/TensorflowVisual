using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput CountUpTo(TFGraph graph, TensorFlow.TFOutput reference, long limit, string operName=null)
		{
			return graph.CountUpTo(reference, limit, operName);
		}
	}
}
