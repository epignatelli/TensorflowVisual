using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ExtractGlimpse(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput size, TensorFlow.TFOutput offsets, System.Boolean? centered=null, System.Boolean? normalized=null, System.Boolean? uniform_noise=null, string operName=null)
		{
			return graph.ExtractGlimpse(input, size, offsets, centered, normalized, uniform_noise, operName);
		}
	}
}
