using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput RangeDataset(TFGraph graph, TensorFlow.TFOutput start, TensorFlow.TFOutput stop, TensorFlow.TFOutput step, TensorFlow.TFDataType[] output_types, TensorFlow.TFShape[] output_shapes, string operName=null)
		{
			return graph.RangeDataset(start, stop, step, output_types, output_shapes, operName);
		}
	}
}
