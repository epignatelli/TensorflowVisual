using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ClipByAverageNorm(this TFGraph graph, TensorFlow.TFOutput x, TensorFlow.TFOutput clip_norm, string operName=null)
		{
			return graph.ClipByAverageNorm(x, clip_norm, operName);
		}
	}
}
