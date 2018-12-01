using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput DenseToSparseBatchDataset(this TFGraph graph, TensorFlow.TFOutput input_dataset, TensorFlow.TFOutput batch_size, TensorFlow.TFOutput row_shape, TensorFlow.TFDataType[] output_types, TensorFlow.TFShape[] output_shapes, string operName=null)
		{
			return graph.DenseToSparseBatchDataset(input_dataset, batch_size, row_shape, output_types, output_shapes, operName);
		}
	}
}
