using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static System.IntPtr get_Handle(this TFGraph graph)
		{
			return graph.get_Handle();
		}
	}
}
