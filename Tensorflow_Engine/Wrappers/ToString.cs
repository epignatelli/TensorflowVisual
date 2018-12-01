using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static string ToString(this TFGraph graph)
		{
			return graph.ToString();
		}
	}
}
