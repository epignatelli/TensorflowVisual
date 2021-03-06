using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput CacheDataset(this TFGraph graph, TensorFlow.TFOutput input_dataset, TensorFlow.TFOutput filename, TensorFlow.TFDataType[] output_types, TensorFlow.TFShape[] output_shapes, string operName=null)
		{
			return graph.CacheDataset(input_dataset, filename, output_types, output_shapes, operName);
		}
	}
}
