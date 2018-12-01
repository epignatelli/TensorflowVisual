using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ZipDataset(this TFGraph graph, TensorFlow.TFOutput[] input_datasets, TensorFlow.TFDataType[] output_types, TensorFlow.TFShape[] output_shapes, string operName=null)
		{
			return graph.ZipDataset(input_datasets, output_types, output_shapes, operName);
		}
	}
}
