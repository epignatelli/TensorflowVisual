using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput StatelessRandomNormal(this TFGraph graph, TensorFlow.TFOutput shape, TensorFlow.TFOutput seed, TensorFlow.TFDataType? dtype=null, string operName=null)
		{
			return graph.StatelessRandomNormal(shape, seed, dtype, operName);
		}
	}
}
