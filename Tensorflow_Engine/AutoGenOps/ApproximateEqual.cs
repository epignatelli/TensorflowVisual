using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ApproximateEqual(this TFGraph graph, TensorFlow.TFOutput x, TensorFlow.TFOutput y, System.Single? tolerance=null, string operName=null)
		{
			return graph.ApproximateEqual(x, y, tolerance, operName);
		}
	}
}
