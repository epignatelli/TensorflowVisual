using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput MatrixBandPart(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput num_lower, TensorFlow.TFOutput num_upper, string operName=null)
		{
			return graph.MatrixBandPart(input, num_lower, num_upper, operName);
		}
	}
}
