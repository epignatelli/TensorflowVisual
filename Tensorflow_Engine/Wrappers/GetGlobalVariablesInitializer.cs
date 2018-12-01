using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation[] GetGlobalVariablesInitializer(this TFGraph graph)
		{
			return graph.GetGlobalVariablesInitializer();
		}
	}
}
