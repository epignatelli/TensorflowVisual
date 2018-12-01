using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput RandomUniformInt(this TFGraph graph, TensorFlow.TFOutput shape, TensorFlow.TFOutput minval, TensorFlow.TFOutput maxval, long? seed=null, long? seed2=null, string operName=null)
		{
			return graph.RandomUniformInt(shape, minval, maxval, seed, seed2, operName);
		}
	}
}
