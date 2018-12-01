using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput RGBToHSV(this TFGraph graph, TensorFlow.TFOutput images, string operName=null)
		{
			return graph.RGBToHSV(images, operName);
		}
	}
}
