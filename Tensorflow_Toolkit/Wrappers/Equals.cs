using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static System.Boolean Equals(TFGraph graph, object obj)
		{
			return graph.Equals(obj);
		}
	}
}
