using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ConjugateTranspose(TFGraph graph, TensorFlow.TFOutput x, TensorFlow.TFOutput perm, string operName=null)
		{
			return graph.ConjugateTranspose(x, perm, operName);
		}
	}
}
