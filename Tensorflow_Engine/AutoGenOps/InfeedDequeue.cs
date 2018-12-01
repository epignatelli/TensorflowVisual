using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput InfeedDequeue(this TFGraph graph, TensorFlow.TFDataType dtype, TensorFlow.TFShape shape, string operName=null)
		{
			return graph.InfeedDequeue(dtype, shape, operName);
		}
	}
}
