using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFFunction ToFunction(this TFGraph graph, string functionName, string description, TensorFlow.TFOperation[] operations, TensorFlow.TFOutput[] inputs, TensorFlow.TFOutput[] outputs, string[] outputNames, System.Boolean appendHashToFunctionName=False, TensorFlow.TFStatus status=null)
		{
			return graph.ToFunction(functionName, description, operations, inputs, outputs, outputNames, appendHashToFunctionName, status);
		}
	}
}
