using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput RGBToHSV(TFGraph graph, TensorFlow.TFOutput images, string operName=null)
		{
			return graph.RGBToHSV(images, operName);
		}
	}
}
