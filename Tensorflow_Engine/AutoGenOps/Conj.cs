using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Conj(this TFGraph graph, TensorFlow.TFOutput input, string operName=null)
		{
			return graph.Conj(input, operName);
		}
	}
}
