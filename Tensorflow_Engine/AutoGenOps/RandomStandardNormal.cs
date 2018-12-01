using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput RandomStandardNormal(this TFGraph graph, TensorFlow.TFOutput shape, TensorFlow.TFDataType dtype, long? seed=null, long? seed2=null, string operName=null)
		{
			return graph.RandomStandardNormal(shape, dtype, seed, seed2, operName);
		}
	}
}
