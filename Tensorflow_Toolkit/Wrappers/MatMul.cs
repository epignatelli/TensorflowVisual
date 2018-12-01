using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput MatMul(TFGraph graph, TensorFlow.TFOutput a, TensorFlow.TFOutput b, System.Boolean? transpose_a=null, System.Boolean? transpose_b=null, string operName=null)
		{
			return graph.MatMul(a, b, transpose_a, transpose_b, operName);
		}
	}
}
