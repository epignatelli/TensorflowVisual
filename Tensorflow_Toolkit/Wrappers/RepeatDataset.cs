using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput RepeatDataset(TFGraph graph, TensorFlow.TFOutput input_dataset, TensorFlow.TFOutput count, TensorFlow.TFDataType[] output_types, TensorFlow.TFShape[] output_shapes, string operName=null)
		{
			return graph.RepeatDataset(input_dataset, count, output_types, output_shapes, operName);
		}
	}
}
