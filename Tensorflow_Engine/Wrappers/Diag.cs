using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Diag(this TFGraph graph, TensorFlow.TFOutput diagonal, string operName=null)
		{
			return graph.Diag(diagonal, operName);
		}
	}
}
