using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput MatMul(this TFGraph graph, TensorFlow.TFOutput a, TensorFlow.TFOutput b, System.Boolean? transpose_a=null, System.Boolean? transpose_b=null, string operName=null)
		{
			return graph.MatMul(a, b, transpose_a, transpose_b, operName);
		}
	}
}
