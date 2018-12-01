using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ShuffleAndRepeatDataset(TFGraph graph, TensorFlow.TFOutput input_dataset, TensorFlow.TFOutput buffer_size, TensorFlow.TFOutput seed, TensorFlow.TFOutput seed2, TensorFlow.TFOutput count, TensorFlow.TFDataType[] output_types, TensorFlow.TFShape[] output_shapes, string operName=null)
		{
			return graph.ShuffleAndRepeatDataset(input_dataset, buffer_size, seed, seed2, count, output_types, output_shapes, operName);
		}
	}
}
