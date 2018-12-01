using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SqlDataset(this TFGraph graph, TensorFlow.TFOutput driver_name, TensorFlow.TFOutput data_source_name, TensorFlow.TFOutput query, TensorFlow.TFDataType[] output_types, TensorFlow.TFShape[] output_shapes, string operName=null)
		{
			return graph.SqlDataset(driver_name, data_source_name, query, output_types, output_shapes, operName);
		}
	}
}
