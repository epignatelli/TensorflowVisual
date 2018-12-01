using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput BiasAdd(TFGraph graph, TensorFlow.TFOutput value, TensorFlow.TFOutput bias, string data_format=null, string operName=null)
		{
			return graph.BiasAdd(value, bias, data_format, operName);
		}
	}
}
