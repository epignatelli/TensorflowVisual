using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput MirrorPadGrad(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput paddings, string mode, string operName=null)
		{
			return graph.MirrorPadGrad(input, paddings, mode, operName);
		}
	}
}
