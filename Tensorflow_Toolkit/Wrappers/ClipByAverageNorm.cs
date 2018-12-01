using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ClipByAverageNorm(TFGraph graph, TensorFlow.TFOutput x, TensorFlow.TFOutput clip_norm, string operName=null)
		{
			return graph.ClipByAverageNorm(x, clip_norm, operName);
		}
	}
}
