using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput RandomShuffleQueueV2(this TFGraph graph, TensorFlow.TFDataType[] component_types, TensorFlow.TFShape[] shapes=null, long? capacity=null, long? min_after_dequeue=null, long? seed=null, long? seed2=null, string container=null, string shared_name=null, string operName=null)
		{
			return graph.RandomShuffleQueueV2(component_types, shapes, capacity, min_after_dequeue, seed, seed2, container, shared_name, operName);
		}
	}
}
