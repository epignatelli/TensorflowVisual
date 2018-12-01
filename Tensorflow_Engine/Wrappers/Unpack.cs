using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput[] Unpack(this TFGraph graph, TensorFlow.TFOutput value, long num, long? axis=null, string operName=null)
		{
			return graph.Unpack(value, num, axis, operName);
		}
	}
}
