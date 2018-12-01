using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Constant(this TFGraph graph, object value, TensorFlow.TFShape tfshape, TensorFlow.TFDataType dtype=TensorFlow.TFDataType.Double, string operName=null)
		{
			return graph.Constant(value, tfshape, dtype, operName);
		}
	}
}
