using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput RandomDataset(this TFGraph graph, TensorFlow.TFOutput seed, TensorFlow.TFOutput seed2, TensorFlow.TFDataType[] output_types, TensorFlow.TFShape[] output_shapes, string operName=null)
		{
			return graph.RandomDataset(seed, seed2, output_types, output_shapes, operName);
		}
	}
}
