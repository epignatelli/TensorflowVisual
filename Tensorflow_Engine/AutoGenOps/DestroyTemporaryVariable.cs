using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput DestroyTemporaryVariable(this TFGraph graph, TensorFlow.TFOutput reference, string var_name, string operName=null)
		{
			return graph.DestroyTemporaryVariable(reference, var_name, operName);
		}
	}
}
