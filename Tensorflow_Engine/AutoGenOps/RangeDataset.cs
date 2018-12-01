using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput RangeDataset(this TFGraph graph, TensorFlow.TFOutput start, TensorFlow.TFOutput stop, TensorFlow.TFOutput step, TensorFlow.TFDataType[] output_types, TensorFlow.TFShape[] output_shapes, string operName=null)
		{
			return graph.RangeDataset(start, stop, step, output_types, output_shapes, operName);
		}
	}
}
