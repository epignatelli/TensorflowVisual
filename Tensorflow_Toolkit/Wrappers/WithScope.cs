using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFScope WithScope(TFGraph graph, string nameScopeDesc)
		{
			return graph.WithScope(nameScopeDesc);
		}
	}
}
