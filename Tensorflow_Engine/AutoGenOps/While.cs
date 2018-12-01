using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput[] While(this TFGraph graph, TensorFlow.TFOutput[] inputs, TensorFlow.TFGraph constructor, TensorFlow.TFStatus status=null)
		{
			return graph.While(inputs, constructor, status);
		}
	}
}
