using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput StatelessRandomUniform(TFGraph graph, TensorFlow.TFOutput shape, TensorFlow.TFOutput seed, TensorFlow.TFDataType? dtype=null, string operName=null)
		{
			return graph.StatelessRandomUniform(shape, seed, dtype, operName);
		}
	}
}
