using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation Abort(this TFGraph graph, string error_msg=null, System.Boolean? exit_without_error=null, string operName=null)
		{
			return graph.Abort(error_msg, exit_without_error, operName);
		}
	}
}
