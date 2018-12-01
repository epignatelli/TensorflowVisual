using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Relu6(TFGraph graph, TensorFlow.TFOutput features, string operName=null)
		{
			return graph.Relu6(features, operName);
		}
	}
}
