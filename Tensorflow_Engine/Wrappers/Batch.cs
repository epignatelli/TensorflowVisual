using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput[],TensorFlow.TFOutput,TensorFlow.TFOutput> Batch(this TFGraph graph, TensorFlow.TFOutput[] in_tensors, long num_batch_threads, long max_batch_size, long batch_timeout_micros, long grad_timeout_micros, long? max_enqueued_batches=null, long[] allowed_batch_sizes=null, string container=null, string shared_name=null, string batching_queue=null, string operName=null)
		{
			return graph.Batch(in_tensors, num_batch_threads, max_batch_size, batch_timeout_micros, grad_timeout_micros, max_enqueued_batches, allowed_batch_sizes, container, shared_name, batching_queue, operName);
		}
	}
}
