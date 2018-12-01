using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFFunction[] get_Functions(this TFGraph graph)
		{
			return graph.get_Functions();
		}
	}
}
