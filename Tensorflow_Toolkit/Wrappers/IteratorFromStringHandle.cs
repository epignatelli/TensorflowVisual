using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput IteratorFromStringHandle(TFGraph graph, TensorFlow.TFOutput string_handle, TensorFlow.TFDataType[] output_types=null, TensorFlow.TFShape[] output_shapes=null, string operName=null)
		{
			return graph.IteratorFromStringHandle(string_handle, output_types, output_shapes, operName);
		}
	}
}
