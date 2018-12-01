using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Iterator(this TFGraph graph, string shared_name, string container, TensorFlow.TFDataType[] output_types, TensorFlow.TFShape[] output_shapes, string operName=null)
		{
			return graph.Iterator(shared_name, container, output_types, output_shapes, operName);
		}
	}
}
