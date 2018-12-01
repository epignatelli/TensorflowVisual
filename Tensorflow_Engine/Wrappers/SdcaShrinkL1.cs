using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation SdcaShrinkL1(this TFGraph graph, TensorFlow.TFOutput[] weights, System.Single l1, System.Single l2, string operName=null)
		{
			return graph.SdcaShrinkL1(weights, l1, l2, operName);
		}
	}
}
