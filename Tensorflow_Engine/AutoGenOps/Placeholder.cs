using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Placeholder(this TFGraph graph, TensorFlow.TFDataType dtype, TensorFlow.TFShape shape=null, string operName=null)
		{
			return graph.Placeholder(dtype, shape, operName);
		}
	}
}
