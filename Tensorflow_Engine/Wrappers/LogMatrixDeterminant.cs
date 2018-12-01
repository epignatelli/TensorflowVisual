using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> LogMatrixDeterminant(this TFGraph graph, TensorFlow.TFOutput input, string operName=null)
		{
			return graph.LogMatrixDeterminant(input, operName);
		}
	}
}
