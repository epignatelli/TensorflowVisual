using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Complex(this TFGraph graph, TensorFlow.TFOutput real, TensorFlow.TFOutput imag, TensorFlow.TFDataType? Tout=null, string operName=null)
		{
			return graph.Complex(real, imag, Tout, operName);
		}
	}
}
