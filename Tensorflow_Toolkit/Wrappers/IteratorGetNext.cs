using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput[] IteratorGetNext(TFGraph graph, TensorFlow.TFOutput iterator, TensorFlow.TFDataType[] output_types, TensorFlow.TFShape[] output_shapes, string operName=null)
		{
			return graph.IteratorGetNext(iterator, output_types, output_shapes, operName);
		}
	}
}