using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput BiasAddV1(this TFGraph graph, TensorFlow.TFOutput value, TensorFlow.TFOutput bias, string operName=null)
		{
			return graph.BiasAddV1(value, bias, operName);
		}
	}
}
