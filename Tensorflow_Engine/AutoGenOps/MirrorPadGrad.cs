using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput MirrorPadGrad(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput paddings, string mode, string operName=null)
		{
			return graph.MirrorPadGrad(input, paddings, mode, operName);
		}
	}
}
