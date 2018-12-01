using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput IdentityReaderV2(this TFGraph graph, string container=null, string shared_name=null, string operName=null)
		{
			return graph.IdentityReaderV2(container, shared_name, operName);
		}
	}
}
