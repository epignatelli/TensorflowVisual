using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput RandomUniform(TFGraph graph, TensorFlow.TFOutput shape, TensorFlow.TFDataType dtype, long? seed=null, long? seed2=null, string operName=null)
		{
			return graph.RandomUniform(shape, dtype, seed, seed2, operName);
		}
	}
}
