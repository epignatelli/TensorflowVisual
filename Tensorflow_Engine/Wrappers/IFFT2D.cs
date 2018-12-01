using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput IFFT2D(this TFGraph graph, TensorFlow.TFOutput input, string operName=null)
		{
			return graph.IFFT2D(input, operName);
		}
	}
}
