using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Real(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFDataType? Tout=null, string operName=null)
		{
			return graph.Real(input, Tout, operName);
		}
	}
}
