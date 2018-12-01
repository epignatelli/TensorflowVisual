using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput IteratorFromStringHandle(this TFGraph graph, TensorFlow.TFOutput string_handle, TensorFlow.TFDataType[] output_types=null, TensorFlow.TFShape[] output_shapes=null, string operName=null)
		{
			return graph.IteratorFromStringHandle(string_handle, output_types, output_shapes, operName);
		}
	}
}
