using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput MatrixInverse(this TFGraph graph, TensorFlow.TFOutput input, System.Boolean? adjoint=null, string operName=null)
		{
			return graph.MatrixInverse(input, adjoint, operName);
		}
	}
}
