using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ConcatV2(this TFGraph graph, TensorFlow.TFOutput[] values, TensorFlow.TFOutput axis, string operName=null)
		{
			return graph.ConcatV2(values, axis, operName);
		}
	}
}
