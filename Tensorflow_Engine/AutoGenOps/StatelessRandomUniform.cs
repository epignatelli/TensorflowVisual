using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput StatelessRandomUniform(this TFGraph graph, TensorFlow.TFOutput shape, TensorFlow.TFOutput seed, TensorFlow.TFDataType? dtype=null, string operName=null)
		{
			return graph.StatelessRandomUniform(shape, seed, dtype, operName);
		}
	}
}
