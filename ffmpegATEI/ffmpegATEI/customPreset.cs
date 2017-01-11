using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffmpegATEI
{
    public class customPreset
    {
        public String vcodec, acodec, abitrate, vbitrate, resolution;

        public customPreset()
        {
            vcodec = null;
            acodec = null;
            abitrate = null;
            vbitrate = null;
            resolution = null;
        }

        public customPreset(String VCODEC,String ACODEC,String ABITRATE,String VBITRATE,String RESOLUTION)
        {
            vcodec = VCODEC;
            acodec = ACODEC;
            abitrate = ABITRATE;
            vbitrate = VBITRATE;
            resolution = RESOLUTION;
        }

    }
}
