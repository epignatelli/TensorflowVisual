using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Pack(TFGraph graph, TensorFlow.TFOutput[] values, long? axis=null, string operName=null)
		{
			return graph.Pack(values, axis, operName);
		}
	}
}
