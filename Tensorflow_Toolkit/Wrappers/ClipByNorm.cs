using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ClipByNorm(TFGraph graph, TensorFlow.TFOutput x, TensorFlow.TFOutput clip_norm, TensorFlow.TFOutput? axes=null, string operName=null)
		{
			return graph.ClipByNorm(x, clip_norm, axes, operName);
		}
	}
}
