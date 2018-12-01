using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TruncatedNormal(this TFGraph graph, TensorFlow.TFOutput shape, TensorFlow.TFDataType dtype, long? seed=null, long? seed2=null, string operName=null)
		{
			return graph.TruncatedNormal(shape, dtype, seed, seed2, operName);
		}
	}
}
