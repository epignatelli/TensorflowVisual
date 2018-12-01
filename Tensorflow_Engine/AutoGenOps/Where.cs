using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Where(this TFGraph graph, TensorFlow.TFOutput condition, TensorFlow.TFOutput? x, TensorFlow.TFOutput? y, string name=null)
		{
			return graph.Where(condition, x, y, name);
		}
	}
}
