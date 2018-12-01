using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput BatchDataset(this TFGraph graph, TensorFlow.TFOutput input_dataset, TensorFlow.TFOutput batch_size, TensorFlow.TFDataType[] output_types, TensorFlow.TFShape[] output_shapes, string operName=null)
		{
			return graph.BatchDataset(input_dataset, batch_size, output_types, output_shapes, operName);
		}
	}
}
