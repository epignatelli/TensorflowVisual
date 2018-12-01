using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ConcatenateDataset(TFGraph graph, TensorFlow.TFOutput input_dataset, TensorFlow.TFOutput another_dataset, TensorFlow.TFDataType[] output_types, TensorFlow.TFShape[] output_shapes, string operName=null)
		{
			return graph.ConcatenateDataset(input_dataset, another_dataset, output_types, output_shapes, operName);
		}
	}
}
