using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Mfcc(this TFGraph graph, TensorFlow.TFOutput spectrogram, TensorFlow.TFOutput sample_rate, System.Single? upper_frequency_limit=null, System.Single? lower_frequency_limit=null, long? filterbank_channel_count=null, long? dct_coefficient_count=null, string operName=null)
		{
			return graph.Mfcc(spectrogram, sample_rate, upper_frequency_limit, lower_frequency_limit, filterbank_channel_count, dct_coefficient_count, operName);
		}
	}
}
