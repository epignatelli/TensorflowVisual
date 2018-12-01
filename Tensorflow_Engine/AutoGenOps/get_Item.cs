using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation get_Item(this TFGraph graph, string name)
		{
			return graph.get_Item(name);
		}
	}
}
