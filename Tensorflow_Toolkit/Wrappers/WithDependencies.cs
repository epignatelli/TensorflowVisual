using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFDependencies WithDependencies(TFGraph graph, TensorFlow.TFOperation[] dependencies)
		{
			return graph.WithDependencies(dependencies);
		}
	}
}
