using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput[] Unpack(TFGraph graph, TensorFlow.TFOutput value, long num, long? axis=null, string operName=null)
		{
			return graph.Unpack(value, num, axis, operName);
		}
	}
}
