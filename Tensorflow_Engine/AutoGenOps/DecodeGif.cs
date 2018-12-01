using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput DecodeGif(this TFGraph graph, TensorFlow.TFOutput contents, string operName=null)
		{
			return graph.DecodeGif(contents, operName);
		}
	}
}
