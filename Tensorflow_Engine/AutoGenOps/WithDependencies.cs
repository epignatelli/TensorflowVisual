using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFDependencies WithDependencies(this TFGraph graph, TensorFlow.TFOperation[] dependencies)
		{
			return graph.WithDependencies(dependencies);
		}
	}
}
