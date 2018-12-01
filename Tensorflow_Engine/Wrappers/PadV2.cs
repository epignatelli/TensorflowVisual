using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput PadV2(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput paddings, TensorFlow.TFOutput constant_values, string operName=null)
		{
			return graph.PadV2(input, paddings, constant_values, operName);
		}
	}
}
