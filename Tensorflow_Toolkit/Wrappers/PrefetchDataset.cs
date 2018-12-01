using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput PrefetchDataset(TFGraph graph, TensorFlow.TFOutput input_dataset, TensorFlow.TFOutput buffer_size, TensorFlow.TFDataType[] output_types, TensorFlow.TFShape[] output_shapes, string operName=null)
		{
			return graph.PrefetchDataset(input_dataset, buffer_size, output_types, output_shapes, operName);
		}
	}
}
