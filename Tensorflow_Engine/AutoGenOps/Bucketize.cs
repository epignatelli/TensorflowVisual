using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Bucketize(this TFGraph graph, TensorFlow.TFOutput input, System.Single[] boundaries, string operName=null)
		{
			return graph.Bucketize(input, boundaries, operName);
		}
	}
}
