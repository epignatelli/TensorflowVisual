using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TensorSliceDataset(TFGraph graph, TensorFlow.TFOutput[] components, TensorFlow.TFShape[] output_shapes, string operName=null)
		{
			return graph.TensorSliceDataset(components, output_shapes, operName);
		}
	}
}
