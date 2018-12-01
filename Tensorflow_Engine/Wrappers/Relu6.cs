using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Relu6(this TFGraph graph, TensorFlow.TFOutput features, string operName=null)
		{
			return graph.Relu6(features, operName);
		}
	}
}
