using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Constant(TFGraph graph, object value, TensorFlow.TFShape tfshape, TensorFlow.TFDataType dtype=Double, string operName=null)
		{
			return graph.Constant(value, tfshape, dtype, operName);
		}
	}
}
