using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput DecodeJpeg(this TFGraph graph, TensorFlow.TFOutput contents, long? channels=null, long? ratio=null, System.Boolean? fancy_upscaling=null, System.Boolean? try_recover_truncated=null, System.Single? acceptable_fraction=null, string dct_method=null, string operName=null)
		{
			return graph.DecodeJpeg(contents, channels, ratio, fancy_upscaling, try_recover_truncated, acceptable_fraction, dct_method, operName);
		}
	}
}
