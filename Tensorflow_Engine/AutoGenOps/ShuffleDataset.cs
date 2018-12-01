using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ShuffleDataset(this TFGraph graph, TensorFlow.TFOutput input_dataset, TensorFlow.TFOutput buffer_size, TensorFlow.TFOutput seed, TensorFlow.TFOutput seed2, TensorFlow.TFDataType[] output_types, TensorFlow.TFShape[] output_shapes, System.Boolean? reshuffle_each_iteration=null, string operName=null)
		{
			return graph.ShuffleDataset(input_dataset, buffer_size, seed, seed2, output_types, output_shapes, reshuffle_each_iteration, operName);
		}
	}
}
