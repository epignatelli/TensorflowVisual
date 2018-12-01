using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TFRecordReader(this TFGraph graph, string container=null, string shared_name=null, string compression_type=null, string operName=null)
		{
			return graph.TFRecordReader(container, shared_name, compression_type, operName);
		}
	}
}
