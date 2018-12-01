using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SdcaFprint(TFGraph graph, TensorFlow.TFOutput input, string operName=null)
		{
			return graph.SdcaFprint(input, operName);
		}
	}
}
