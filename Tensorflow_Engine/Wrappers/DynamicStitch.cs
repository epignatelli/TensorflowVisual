using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput DynamicStitch(this TFGraph graph, TensorFlow.TFOutput[] indices, TensorFlow.TFOutput[] data, string operName=null)
		{
			return graph.DynamicStitch(indices, data, operName);
		}
	}
}
