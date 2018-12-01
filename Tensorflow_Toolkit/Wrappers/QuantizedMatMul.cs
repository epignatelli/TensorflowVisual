using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> QuantizedMatMul(TFGraph graph, TensorFlow.TFOutput a, TensorFlow.TFOutput b, TensorFlow.TFOutput min_a, TensorFlow.TFOutput max_a, TensorFlow.TFOutput min_b, TensorFlow.TFOutput max_b, TensorFlow.TFDataType? Toutput=null, System.Boolean? transpose_a=null, System.Boolean? transpose_b=null, TensorFlow.TFDataType? Tactivation=null, string operName=null)
		{
			return graph.QuantizedMatMul(a, b, min_a, max_a, min_b, max_b, Toutput, transpose_a, transpose_b, Tactivation, operName);
		}
	}
}
