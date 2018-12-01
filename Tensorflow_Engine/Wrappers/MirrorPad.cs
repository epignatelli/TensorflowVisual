using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput MirrorPad(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput paddings, string mode, string operName=null)
		{
			return graph.MirrorPad(input, paddings, mode, operName);
		}
	}
}
