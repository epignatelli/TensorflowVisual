using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Reshape(this TFGraph graph, TensorFlow.TFOutput tensor, TensorFlow.TFOutput shape, string operName=null)
		{
			return graph.Reshape(tensor, shape, operName);
		}
	}
}
