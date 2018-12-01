using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput[] IteratorGetNextSync(this TFGraph graph, TensorFlow.TFOutput iterator, TensorFlow.TFDataType[] output_types, TensorFlow.TFShape[] output_shapes, string operName=null)
		{
			return graph.IteratorGetNextSync(iterator, output_types, output_shapes, operName);
		}
	}
}
