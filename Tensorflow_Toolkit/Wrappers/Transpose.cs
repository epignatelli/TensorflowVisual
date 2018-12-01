using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Transpose(TFGraph graph, TensorFlow.TFOutput x, TensorFlow.TFOutput perm, string operName=null)
		{
			return graph.Transpose(x, perm, operName);
		}
	}
}
