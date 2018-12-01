using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput RestoreSlice(this TFGraph graph, TensorFlow.TFOutput file_pattern, TensorFlow.TFOutput tensor_name, TensorFlow.TFOutput shape_and_slice, TensorFlow.TFDataType dt, long? preferred_shard=null, string operName=null)
		{
			return graph.RestoreSlice(file_pattern, tensor_name, shape_and_slice, dt, preferred_shard, operName);
		}
	}
}
