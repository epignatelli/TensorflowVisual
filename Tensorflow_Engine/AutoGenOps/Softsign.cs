using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Softsign(this TFGraph graph, TensorFlow.TFOutput features, string operName=null)
		{
			return graph.Softsign(features, operName);
		}
	}
}
