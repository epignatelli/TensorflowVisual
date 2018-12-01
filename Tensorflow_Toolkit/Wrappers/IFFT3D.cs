using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput IFFT3D(TFGraph graph, TensorFlow.TFOutput input, string operName=null)
		{
			return graph.IFFT3D(input, operName);
		}
	}
}
