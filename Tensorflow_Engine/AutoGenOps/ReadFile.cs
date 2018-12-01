using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ReadFile(this TFGraph graph, TensorFlow.TFOutput filename, string operName=null)
		{
			return graph.ReadFile(filename, operName);
		}
	}
}
