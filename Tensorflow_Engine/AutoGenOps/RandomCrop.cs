using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput RandomCrop(this TFGraph graph, TensorFlow.TFOutput image, TensorFlow.TFOutput size, long? seed=null, long? seed2=null, string operName=null)
		{
			return graph.RandomCrop(image, size, seed, seed2, operName);
		}
	}
}
