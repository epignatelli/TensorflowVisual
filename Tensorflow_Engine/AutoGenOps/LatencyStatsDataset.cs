using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput LatencyStatsDataset(this TFGraph graph, TensorFlow.TFOutput input_dataset, TensorFlow.TFOutput tag, TensorFlow.TFDataType[] output_types, TensorFlow.TFShape[] output_shapes, string operName=null)
		{
			return graph.LatencyStatsDataset(input_dataset, tag, output_types, output_shapes, operName);
		}
	}
}
