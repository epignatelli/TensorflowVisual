using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFScope WithScope(this TFGraph graph, string nameScopeDesc)
		{
			return graph.WithScope(nameScopeDesc);
		}
	}
}
