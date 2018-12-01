using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput LMDBReader(this TFGraph graph, string container=null, string shared_name=null, string operName=null)
		{
			return graph.LMDBReader(container, shared_name, operName);
		}
	}
}
