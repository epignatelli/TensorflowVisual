using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Imag(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFDataType? Tout=null, string operName=null)
		{
			return graph.Imag(input, Tout, operName);
		}
	}
}
