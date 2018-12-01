using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput PriorityQueue(this TFGraph graph, TensorFlow.TFShape[] shapes, TensorFlow.TFDataType[] component_types=null, long? capacity=null, string container=null, string shared_name=null, string operName=null)
		{
			return graph.PriorityQueue(shapes, component_types, capacity, container, shared_name, operName);
		}
	}
}
