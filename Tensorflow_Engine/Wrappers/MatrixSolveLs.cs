using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput MatrixSolveLs(this TFGraph graph, TensorFlow.TFOutput matrix, TensorFlow.TFOutput rhs, TensorFlow.TFOutput l2_regularizer, System.Boolean? fast=null, string operName=null)
		{
			return graph.MatrixSolveLs(matrix, rhs, l2_regularizer, fast, operName);
		}
	}
}
