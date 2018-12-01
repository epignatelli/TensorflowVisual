using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ConjugateTranspose(this TFGraph graph, TensorFlow.TFOutput x, TensorFlow.TFOutput perm, string operName=null)
		{
			return graph.ConjugateTranspose(x, perm, operName);
		}
	}
}
