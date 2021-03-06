using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput PlaceholderV2(this TFGraph graph, TensorFlow.TFDataType dtype, TensorFlow.TFShape shape, string operName=null)
		{
			return graph.PlaceholderV2(dtype, shape, operName);
		}
	}
}
