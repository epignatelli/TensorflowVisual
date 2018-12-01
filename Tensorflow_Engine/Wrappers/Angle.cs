using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Angle(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFDataType? Tout=null, string operName=null)
		{
			return graph.Angle(input, Tout, operName);
		}
	}
}
