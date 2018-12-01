using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ZipDataset(TFGraph graph, TensorFlow.TFOutput[] input_datasets, TensorFlow.TFDataType[] output_types, TensorFlow.TFShape[] output_shapes, string operName=null)
		{
			return graph.ZipDataset(input_datasets, output_types, output_shapes, operName);
		}
	}
}
