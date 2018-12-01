using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput RecordInput(this TFGraph graph, string file_pattern, long? file_random_seed=null, System.Single? file_shuffle_shift_ratio=null, long? file_buffer_size=null, long? file_parallelism=null, long? batch_size=null, string compression_type=null, string operName=null)
		{
			return graph.RecordInput(file_pattern, file_random_seed, file_shuffle_shift_ratio, file_buffer_size, file_parallelism, batch_size, compression_type, operName);
		}
	}
}
