using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ExtractImagePatches(this TFGraph graph, TensorFlow.TFOutput images, long[] ksizes, long[] strides, long[] rates, string padding, string operName=null)
		{
			return graph.ExtractImagePatches(images, ksizes, strides, rates, padding, operName);
		}
	}
}
