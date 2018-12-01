using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput PaddingFIFOQueue(TFGraph graph, TensorFlow.TFDataType[] component_types, TensorFlow.TFShape[] shapes=null, long? capacity=null, string container=null, string shared_name=null, string operName=null)
		{
			return graph.PaddingFIFOQueue(component_types, shapes, capacity, container, shared_name, operName);
		}
	}
}
