using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ConcatenateDataset(this TFGraph graph, TensorFlow.TFOutput input_dataset, TensorFlow.TFOutput another_dataset, TensorFlow.TFDataType[] output_types, TensorFlow.TFShape[] output_shapes, string operName=null)
		{
			return graph.ConcatenateDataset(input_dataset, another_dataset, output_types, output_shapes, operName);
		}
	}
}
