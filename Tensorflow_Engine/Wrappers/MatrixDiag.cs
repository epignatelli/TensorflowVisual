using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput MatrixDiag(this TFGraph graph, TensorFlow.TFOutput diagonal, string operName=null)
		{
			return graph.MatrixDiag(diagonal, operName);
		}
	}
}
