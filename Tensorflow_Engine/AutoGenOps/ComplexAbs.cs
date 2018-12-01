using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ComplexAbs(this TFGraph graph, TensorFlow.TFOutput x, TensorFlow.TFDataType? Tout=null, string operName=null)
		{
			return graph.ComplexAbs(x, Tout, operName);
		}
	}
}
