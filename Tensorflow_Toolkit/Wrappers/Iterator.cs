using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Iterator(TFGraph graph, string shared_name, string container, TensorFlow.TFDataType[] output_types, TensorFlow.TFShape[] output_shapes, string operName=null)
		{
			return graph.Iterator(shared_name, container, output_types, output_shapes, operName);
		}
	}
}
