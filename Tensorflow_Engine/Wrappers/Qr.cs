using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> Qr(this TFGraph graph, TensorFlow.TFOutput input, System.Boolean? full_matrices=null, string operName=null)
		{
			return graph.Qr(input, full_matrices, operName);
		}
	}
}
