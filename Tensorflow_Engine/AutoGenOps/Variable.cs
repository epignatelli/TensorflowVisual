using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.Variable Variable(this TFGraph graph, TensorFlow.TFOutput initialValue, System.Boolean trainable=true, string operName=null)
		{
			return graph.Variable(initialValue, trainable, operName);
		}
	}
}
