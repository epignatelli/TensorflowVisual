using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput PadV2(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput paddings, TensorFlow.TFOutput constant_values, string operName=null)
		{
			return graph.PadV2(input, paddings, constant_values, operName);
		}
	}
}
