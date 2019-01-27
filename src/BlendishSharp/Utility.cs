using System;
using System.Runtime.InteropServices;

namespace BlendishSharp
{
	partial class Blendish
	{
		private static int _isnan(double v)
		{
			return v == double.NaN ? 1 : 0;
		}

		public static float bnd_fminf(float a, float b)
		{
			return (float)((_isnan((double)(a))) != 0 ? b : ((_isnan((double)(b))) != 0 ? a : (((a) < (b)) ? a : b)));
		}

		public static float bnd_fmaxf(float a, float b)
		{
			return (float)((_isnan((double)(a))) != 0 ? b : ((_isnan((double)(b))) != 0 ? a : (((a) > (b)) ? a : b)));
		}

		public static double bnd_fmin(double a, double b)
		{
			return (double)((_isnan((double)(a))) != 0 ? b : ((_isnan((double)(b))) != 0 ? a : (((a) < (b)) ? a : b)));
		}

		public static double bnd_fmax(double a, double b)
		{
			return (double)((_isnan((double)(a))) != 0 ? b : ((_isnan((double)(b))) != 0 ? a : (((a) > (b)) ? a : b)));
		}

		public static float bnd_clamp(float v, float mn, float mx)
		{
			return (float)(((v) > (mx)) ? mx : ((v) < (mn)) ? mn : v);
		}
	}
}
