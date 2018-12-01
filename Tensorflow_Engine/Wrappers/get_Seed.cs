using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static int? get_Seed(this TFGraph graph)
		{
			return graph.get_Seed();
		}
	}
}
