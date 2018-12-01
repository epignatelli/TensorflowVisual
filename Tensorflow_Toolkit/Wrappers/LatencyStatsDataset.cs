using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput LatencyStatsDataset(TFGraph graph, TensorFlow.TFOutput input_dataset, TensorFlow.TFOutput tag, TensorFlow.TFDataType[] output_types, TensorFlow.TFShape[] output_shapes, string operName=null)
		{
			return graph.LatencyStatsDataset(input_dataset, tag, output_types, output_shapes, operName);
		}
	}
}
