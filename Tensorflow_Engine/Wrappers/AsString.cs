using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput AsString(this TFGraph graph, TensorFlow.TFOutput input, long? precision=null, System.Boolean? scientific=null, System.Boolean? shortest=null, long? width=null, string fill=null, string operName=null)
		{
			return graph.AsString(input, precision, scientific, shortest, width, fill, operName);
		}
	}
}
