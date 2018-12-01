using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TextLineDataset(TFGraph graph, TensorFlow.TFOutput filenames, TensorFlow.TFOutput compression_type, TensorFlow.TFOutput buffer_size, string operName=null)
		{
			return graph.TextLineDataset(filenames, compression_type, buffer_size, operName);
		}
	}
}
