using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static System.Boolean Equals(this TFGraph graph, object obj)
		{
			return graph.Equals(obj);
		}
	}
}
