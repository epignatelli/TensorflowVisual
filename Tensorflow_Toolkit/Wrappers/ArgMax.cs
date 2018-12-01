using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ArgMax(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput dimension, TensorFlow.TFDataType? output_type=null, string operName=null)
		{
			return graph.ArgMax(input, dimension, output_type, operName);
		}
	}
}
