using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TensorDataset(this TFGraph graph, TensorFlow.TFOutput[] components, TensorFlow.TFShape[] output_shapes, string operName=null)
		{
			return graph.TensorDataset(components, output_shapes, operName);
		}
	}
}
