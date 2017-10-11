using System;

namespace KursRvyanin
{
    class StretchingWav
    {
        //A method that implements OLA algorithm
        public static double[] Stretch(double[] src, double ratio, int frameLength, int overlapLength, int searchLength)
        {
            //Create an array for the modified Wav file
            //length equal to the length of the original Wav file (src.Length), 
            //multiplied by the duration of the rate of change (ratio) 
            double[] dst = new double[(int)(ratio * src.Length)];
            //Copy first frame in target wav
            Array.Copy(src, dst, frameLength);
            int curDstEndIndex = frameLength;

            while (true)
            {
                //Index of start overlaping of in WAV source
                int srcStartIndex = (int)((double)curDstEndIndex / dst.Length * src.Length);
                //Index of start overlaping of in WAV target
                int connectStartIndex = FindConnectStartIndex(dst, curDstEndIndex, src, srcStartIndex, overlapLength, searchLength);
                for (var t = 0; t < overlapLength; t++)
                {
                    if (connectStartIndex + t == dst.Length || srcStartIndex + t == src.Length) return dst;//the end of source or target
                    double a = (double)t / overlapLength;
                    dst[connectStartIndex + t] = a * src[srcStartIndex + t] + (1 - a) * dst[connectStartIndex + t];
                }
                for (var t = overlapLength; t < frameLength; t++)
                {
                    if (connectStartIndex + t == dst.Length || srcStartIndex + t == src.Length) return dst;//the end of source or target
                    dst[connectStartIndex + t] = src[srcStartIndex + t];
                }
                curDstEndIndex = connectStartIndex + frameLength;
            }
        }
        //Check the difference between source and target frames
        private static double CalculateDifference(double[] dst, int dstStartIndex, double[] src, int srcStartIndex, int overlapLength)
        {
            double sum = 0;

            for (int t = 0; t < overlapLength; t++)
            {
                double d = dst[dstStartIndex + t] - src[srcStartIndex + t];
                sum += d * d;
            }
            return sum;
        }
        //Searching connect start index to overlap frame
        private static int FindConnectStartIndex(double[] dst, int dstEndIndex, double[] src, int srcStartIndex, int overlapLength, int searchLength)
        {
            var dstSearchStartIndex = dstEndIndex - overlapLength - searchLength;
            var minDiff = double.MaxValue;
            var minDiffIndex = new int();
            for (var t = 0; t < searchLength; t++)
            {
                var diff = CalculateDifference(dst, dstSearchStartIndex + t, src, srcStartIndex, overlapLength);
                if (diff < minDiff)
                {
                    minDiff = diff;
                    minDiffIndex = dstSearchStartIndex + t;
                }
            }
            return minDiffIndex;
        }
    }
}
