using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Ones(this TFGraph graph, TensorFlow.TFShape shape, TensorFlow.TFDataType dtype=TensorFlow.TFDataType.Double, string operName=null)
		{
			return graph.Ones(shape, dtype, operName);
		}
	}
}
