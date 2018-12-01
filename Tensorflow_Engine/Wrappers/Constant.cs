using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Constant(this TFGraph graph, object value, TensorFlow.TFShape tfshape, TensorFlow.TFDataType dtype=2, string operName=null)
		{
			return graph.Constant(value, tfshape, dtype, operName);
		}
	}
}
