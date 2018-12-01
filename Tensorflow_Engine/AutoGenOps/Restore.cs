using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Restore(this TFGraph graph, TensorFlow.TFOutput file_pattern, TensorFlow.TFOutput tensor_name, TensorFlow.TFDataType dt, long? preferred_shard=null, string operName=null)
		{
			return graph.Restore(file_pattern, tensor_name, dt, preferred_shard, operName);
		}
	}
}
