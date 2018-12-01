using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> MaxPoolWithArgmax(TFGraph graph, TensorFlow.TFOutput input, long[] ksize, long[] strides, string padding, TensorFlow.TFDataType? Targmax=null, string operName=null)
		{
			return graph.MaxPoolWithArgmax(input, ksize, strides, padding, Targmax, operName);
		}
	}
}
