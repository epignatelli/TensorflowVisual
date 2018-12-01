using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput IsVariableInitialized(this TFGraph graph, TensorFlow.TFOutput reference, string operName=null)
		{
			return graph.IsVariableInitialized(reference, operName);
		}
	}
}
