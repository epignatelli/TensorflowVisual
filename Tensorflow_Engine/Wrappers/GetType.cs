using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static System.Type GetType(this TFGraph graph)
		{
			return graph.GetType();
		}
	}
}
