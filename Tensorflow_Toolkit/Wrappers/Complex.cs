using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Complex(TFGraph graph, TensorFlow.TFOutput real, TensorFlow.TFOutput imag, TensorFlow.TFDataType? Tout=null, string operName=null)
		{
			return graph.Complex(real, imag, Tout, operName);
		}
	}
}
