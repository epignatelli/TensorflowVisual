using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ArgMax(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput dimension, TensorFlow.TFDataType? output_type=null, string operName=null)
		{
			return graph.ArgMax(input, dimension, output_type, operName);
		}
	}
}
