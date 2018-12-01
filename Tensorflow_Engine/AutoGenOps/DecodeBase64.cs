using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput DecodeBase64(this TFGraph graph, TensorFlow.TFOutput input, string operName=null)
		{
			return graph.DecodeBase64(input, operName);
		}
	}
}
