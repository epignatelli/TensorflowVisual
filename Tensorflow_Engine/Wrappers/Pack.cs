using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Pack(this TFGraph graph, TensorFlow.TFOutput[] values, long? axis=null, string operName=null)
		{
			return graph.Pack(values, axis, operName);
		}
	}
}
