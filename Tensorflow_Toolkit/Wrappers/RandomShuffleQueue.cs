using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput RandomShuffleQueue(TFGraph graph, TensorFlow.TFDataType[] component_types, TensorFlow.TFShape[] shapes=null, long? capacity=null, long? min_after_dequeue=null, long? seed=null, long? seed2=null, string container=null, string shared_name=null, string operName=null)
		{
			return graph.RandomShuffleQueue(component_types, shapes, capacity, min_after_dequeue, seed, seed2, container, shared_name, operName);
		}
	}
}
