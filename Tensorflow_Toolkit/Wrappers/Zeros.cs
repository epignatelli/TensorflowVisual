using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Zeros(TFGraph graph, TensorFlow.TFShape shape, TensorFlow.TFDataType dtype=Double, string operName=null)
		{
			return graph.Zeros(shape, dtype, operName);
		}
	}
}
