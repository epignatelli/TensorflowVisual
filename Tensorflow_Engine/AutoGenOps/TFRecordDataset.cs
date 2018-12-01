using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TFRecordDataset(this TFGraph graph, TensorFlow.TFOutput filenames, TensorFlow.TFOutput compression_type, TensorFlow.TFOutput buffer_size, string operName=null)
		{
			return graph.TFRecordDataset(filenames, compression_type, buffer_size, operName);
		}
	}
}
