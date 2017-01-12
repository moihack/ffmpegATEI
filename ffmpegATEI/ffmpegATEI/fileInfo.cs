using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediaInfoNET;

namespace ffmpegATEI
{
    class fileInfo
    {
        public String frameNumber, info;

        public fileInfo()
        {

        }

        public fileInfo(String path)
        {
            //String info = null;

            Boolean hasAudio = false;
            Boolean hasVideo = false;         

            /* The wrapper mediaInfo library does not correctly determine audio bitrate (always returns 0).
               To solve this, we first check if there is a video stream. 
               If there is one, then audio bitrate is the total file bitrate minus the video bitrate.
               If there is audio only and no video, the total file bitrate is the audio bitrate.
               The above workaround is implemented in code below.
            */
          
            MediaFile mediaFile = new MediaFile(path);

            //start of workaround
            int realAudioBitrate = 0;

            if (mediaFile.Video.Count > 0)
            {
                hasVideo = true;
            }

            if (mediaFile.Audio.Count > 0)
            {
                hasAudio = true;

                if (hasVideo)
                {
                    realAudioBitrate = mediaFile.General.Bitrate - mediaFile.Video[0].Bitrate;
                    frameNumber = (mediaFile.FrameCount / 1000).ToString();
                }
                else
                {
                    realAudioBitrate = mediaFile.General.Bitrate;
                }

            }
            //end of workaround

            info +=("General:");
            info +="\n";
            info +=("File Name   : " +  mediaFile.Name + "\n");
            info +=("Format      : " +  mediaFile.General.Format + "\n");
            info +=("Duration    : " +  mediaFile.General.DurationString + "\n");
            info +=("Bitrate     : " +  mediaFile.General.Bitrate + "\n");

                      
            if (hasAudio)
            {
                info +="\n";
                info +=("Audio:");
                info +="\n";
                info +=("Format      : " + mediaFile.Audio[0].Format + "\n");
                info +=("Bitrate     : " + realAudioBitrate + "\n");             
                info +=("Channels    : " + mediaFile.Audio[0].Channels.ToString() + "\n" );
                info +=("Sampling    : " + mediaFile.Audio[0].SamplingRate.ToString() + "\n");

            }

            if (hasVideo)
            {
                info +="\n";
                info +=("Video:");
                info +="\n";
                info +=("Format      : " + mediaFile.Video[0].Format + "\n");
                info +=("Bitrate    : "  + mediaFile.Video[0].Bitrate.ToString() + "\n");
                info +=("Frame rate  : " + mediaFile.Video[0].FrameRate.ToString() + "\n");
                info +=("Frame size  : " + mediaFile.Video[0].FrameSize.ToString() + "\n");
            }

            //System.Windows.Forms.MessageBox.Show(info);

            //int test = mediaFile.Video[0].

            //return test.ToString();
            //return mediaFile.FrameCount.ToString();
            //return (mediaFile.FrameCount / 1000).ToString();
            //return info;
        }
       
    }
}
