using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TensorSliceDataset(this TFGraph graph, TensorFlow.TFOutput[] components, TensorFlow.TFShape[] output_shapes, string operName=null)
		{
			return graph.TensorSliceDataset(components, output_shapes, operName);
		}
	}
}
