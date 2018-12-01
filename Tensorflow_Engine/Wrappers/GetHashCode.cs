using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static int GetHashCode(this TFGraph graph)
		{
			return graph.GetHashCode();
		}
	}
}
