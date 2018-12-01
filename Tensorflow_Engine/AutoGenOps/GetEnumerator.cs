using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static IEnumerable<TensorFlow.TFOperation> GetEnumerator(this TFGraph graph)
		{
			return graph.GetEnumerator();
		}
	}
}
