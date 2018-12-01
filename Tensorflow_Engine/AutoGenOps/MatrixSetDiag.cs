using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput MatrixSetDiag(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput diagonal, string operName=null)
		{
			return graph.MatrixSetDiag(input, diagonal, operName);
		}
	}
}
