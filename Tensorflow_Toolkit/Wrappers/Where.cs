using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Where(TFGraph graph, TensorFlow.TFOutput condition, TensorFlow.TFOutput? x, TensorFlow.TFOutput? y, string name=null)
		{
			return graph.Where(condition, x, y, name);
		}
	}
}
