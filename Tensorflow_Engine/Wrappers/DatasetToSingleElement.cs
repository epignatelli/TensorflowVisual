using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput[] DatasetToSingleElement(this TFGraph graph, TensorFlow.TFOutput dataset, TensorFlow.TFDataType[] output_types, TensorFlow.TFShape[] output_shapes, string operName=null)
		{
			return graph.DatasetToSingleElement(dataset, output_types, output_shapes, operName);
		}
	}
}
