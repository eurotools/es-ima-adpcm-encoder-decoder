namespace ImaAdpcm_Tool
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public static partial class ImaCodec
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        public static short[] Decode(byte[] ImaFileData, int numSamples)
        {
            int inp;            /* Input buffer pointer */
            short[] outBuff = new short[numSamples]; /* output buffer pointer */
            int outIndex = 0;   /* Output buffer pointer */
            int sign;           /* Current adpcm sign bit */
            int delta;          /* Current adpcm output value */
            int step;           /* Stepsize */
            int valpred;        /* Predicted value */
            int vpdiff;         /* Current change to valpred */
            int index;          /* Current step change index */
            int inputbuffer;    /* Place to keep next 4-bit value */
            bool bufferstep;    /* Toggle between inputbuffer/input */

            ImaAdpcmState state = new ImaAdpcmState();
            inp = 0;
            inputbuffer = 0;

            valpred = state.valprev;
            index = state.index;
            step = stepsizeTable[index];

            bufferstep = false;

            for (; numSamples > 0; numSamples--)
            {
                /* Step 1 - get the delta value */
                if (bufferstep)
                {
                    delta = inputbuffer & 0xf;
                }
                else
                {
                    inputbuffer = ImaFileData[inp++];
                    delta = (inputbuffer >> 4) & 0xf;
                }
                bufferstep = !bufferstep;

                /* Step 2 - Find new index value (for later) */
                index += indexTable[delta];
                if (index < 0) index = 0;
                if (index > 88) index = 88;

                /* Step 3 - Separate sign and magnitude */
                sign = delta & 8;
                delta &= 7;

                /* Step 4 - Compute difference and new predicted value */
                /*
                ** Computes 'vpdiff = (delta+0.5)*step/4', but see comment
                ** in adpcm_coder.
                */
                vpdiff = step >> 3;
                if ((delta & 4) != 0) vpdiff += step;
                if ((delta & 2) != 0) vpdiff += step >> 1;
                if ((delta & 1) != 0) vpdiff += step >> 2;

                if (sign != 0)
                    valpred -= vpdiff;
                else
                    valpred += vpdiff;

                /* Step 5 - clamp output value */
                if (valpred > short.MaxValue)
                    valpred = short.MaxValue;
                else if (valpred < short.MinValue)
                    valpred = short.MinValue;

                /* Step 6 - Update step value */
                step = stepsizeTable[index];

                /* Step 7 - Output value */
                outBuff[outIndex++] = (short)valpred;
            }

            state.valprev = valpred;
            state.index = index;

            return outBuff;
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
