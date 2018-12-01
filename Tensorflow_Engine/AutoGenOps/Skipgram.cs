using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> Skipgram(this TFGraph graph, string filename, long batch_size, long? window_size=null, long? min_count=null, System.Single? subsample=null, string operName=null)
		{
			return graph.Skipgram(filename, batch_size, window_size, min_count, subsample, operName);
		}
	}
}
