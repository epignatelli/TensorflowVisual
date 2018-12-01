using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Transpose(this TFGraph graph, TensorFlow.TFOutput x, TensorFlow.TFOutput perm, string operName=null)
		{
			return graph.Transpose(x, perm, operName);
		}
	}
}
