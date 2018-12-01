using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput DecodeAndCropJpeg(TFGraph graph, TensorFlow.TFOutput contents, TensorFlow.TFOutput crop_window, long? channels=null, long? ratio=null, System.Boolean? fancy_upscaling=null, System.Boolean? try_recover_truncated=null, System.Single? acceptable_fraction=null, string dct_method=null, string operName=null)
		{
			return graph.DecodeAndCropJpeg(contents, crop_window, channels, ratio, fancy_upscaling, try_recover_truncated, acceptable_fraction, dct_method, operName);
		}
	}
}
