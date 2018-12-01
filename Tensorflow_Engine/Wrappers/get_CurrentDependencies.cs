using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation[] get_CurrentDependencies(this TFGraph graph)
		{
			return graph.get_CurrentDependencies();
		}
	}
}
