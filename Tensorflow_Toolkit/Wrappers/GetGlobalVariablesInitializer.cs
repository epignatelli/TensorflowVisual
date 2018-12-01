using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation[] GetGlobalVariablesInitializer(TFGraph graph)
		{
			return graph.GetGlobalVariablesInitialize);
		}
	}
}