using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput BatchDataset(TFGraph graph, TensorFlow.TFOutput input_dataset, TensorFlow.TFOutput batch_size, TensorFlow.TFDataType[] output_types, TensorFlow.TFShape[] output_shapes, string operName=null)
		{
			return graph.BatchDataset(input_dataset, batch_size, output_types, output_shapes, operName);
		}
	}
}
