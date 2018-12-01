using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation get_Item(TFGraph graph, string name)
		{
			return graph.get_Item(name);
		}
	}
}
