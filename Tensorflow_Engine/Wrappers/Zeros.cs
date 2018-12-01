using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Zeros(this TFGraph graph, TensorFlow.TFShape shape, TensorFlow.TFDataType dtype=2, string operName=null)
		{
			return graph.Zeros(shape, dtype, operName);
		}
	}
}
