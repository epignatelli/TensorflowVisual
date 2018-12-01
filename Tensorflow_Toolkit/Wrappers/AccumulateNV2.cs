using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput AccumulateNV2(TFGraph graph, TensorFlow.TFOutput[] inputs, TensorFlow.TFShape shape, string operName=null)
		{
			return graph.AccumulateNV2(inputs, shape, operName);
		}
	}
}
