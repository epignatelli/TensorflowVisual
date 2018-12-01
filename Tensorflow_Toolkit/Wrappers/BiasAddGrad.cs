using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput BiasAddGrad(TFGraph graph, TensorFlow.TFOutput out_backprop, string data_format=null, string operName=null)
		{
			return graph.BiasAddGrad(out_backprop, data_format, operName);
		}
	}
}
