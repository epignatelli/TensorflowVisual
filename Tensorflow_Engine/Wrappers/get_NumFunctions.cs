using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static int get_NumFunctions(this TFGraph graph)
		{
			return graph.get_NumFunctions();
		}
	}
}
