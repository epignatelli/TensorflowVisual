using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static string get_CurrentNameScope(this TFGraph graph)
		{
			return graph.get_CurrentNameScope();
		}
	}
}
