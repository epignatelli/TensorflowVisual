using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput CacheDataset(TFGraph graph, TensorFlow.TFOutput input_dataset, TensorFlow.TFOutput filename, TensorFlow.TFDataType[] output_types, TensorFlow.TFShape[] output_shapes, string operName=null)
		{
			return graph.CacheDataset(input_dataset, filename, output_types, output_shapes, operName);
		}
	}
}
