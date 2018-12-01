using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput DecodeGif(TFGraph graph, TensorFlow.TFOutput contents, string operName=null)
		{
			return graph.DecodeGif(contents, operName);
		}
	}
}
