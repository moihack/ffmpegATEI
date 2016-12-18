using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace ffmpegATEI
{
    public class ffPresets
    {
        public ffmpegTEI formRef;
        public int totalFrameCount ;

        public ffPresets(ffmpegTEI formex)
        {
            formRef = formex;
        }

        public void detectPreset(String inputFile, String outputDirectory,String preset, ffmpegTEI formt,int frameCount)
        {
            this.formRef = formt;
            this.totalFrameCount = frameCount;

            switch(preset)
            {
                case "Audio Only":
                    AudioOnly(inputFile, outputDirectory);
                    break;

                case "Video Only":
                    VideoOnly(inputFile, outputDirectory);
                    break;

                case "PSP":
                    PSP(inputFile, outputDirectory);
                    break;

                default:
                    MessageBox.Show("Incorrect preset selected!");
                    break;
            }

        }

        private void test()
        {

        }

        private void AudioOnly(String inputFile,String outputDirectory)
        {
            //MessageBox.Show(inputFile+  "   "+outputDirectory);
            //enclose path names with " " so ffmpeg can handle spaces correctly
            String parameters = "-y -i " + '"' + inputFile + '"' +  " -vn -acodec copy " + " " + '"' + outputDirectory + "\\AudioOnly.m4a" + '"';
            doConvert(parameters);
        }

        private void VideoOnly(String inputFile, String outputDirectory)
        {
            //enclose path names with " " so ffmpeg can handle spaces correctly
            String parameters = "-y -i " + '"' + inputFile + '"' + " -vcodec copy -an " + " "+'"'+outputDirectory+"\\VideoOnly.mp4"+'"';
            doConvert(parameters);
        }

        private void PSP(String inputFile, String outputDirectory)
        {
            //ffmpeg -i source_video.avi -b 300 -s 320x240 -vcodec xvid -ab 32 -ar 24000 -acodec aac final_video.mp4
            //enclose path names with " " so ffmpeg can handle spaces correctly
            String parameters = "-y -i " + '"' + inputFile + '"' + " -b:v 300k -s  320x240 -vcodec libxvid -b:a 32k -ar 24000 -acodec aac " + " " + '"' + outputDirectory + "\\PSP.mp4" + '"';
            //MessageBox.Show(parameters);
            doConvert(parameters);
        }

        private void doConvert(String parameters)
        {
            //int totalFrameCount = 6750000;
            //MessageBox.Show(inputFile);
            //MessageBox.Show(outputDirectory);
            Process myProcess = new Process();
            string cmd = parameters;
            //MessageBox.Show(cmd);
            try
            {
                myProcess.StartInfo.UseShellExecute = false;
                myProcess.StartInfo.FileName = Application.StartupPath + "\\bin\\ffmpeg.exe";
                //MessageBox.Show(cmd);
                //MessageBox.Show(myProcess.StartInfo.FileName);
                //myProcess.StartInfo.CreateNoWindow = false;
                myProcess.StartInfo.Arguments = cmd;
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.StartInfo.RedirectStandardError = true;
                myProcess.Start();
                
                //DO NOT remove the output error, otherwise ffmpeg likes to 'sleep' in the background and never comes back!
                while (!myProcess.StandardError.EndOfStream)
                {
                    string line = myProcess.StandardError.ReadLine();
                    if (line.Contains("frame="))
                    {
                        //String currentFramestr = "";
                        String currentFramestr = line.Substring(7, 5);
                        int currentFrameInt = Int32.Parse(currentFramestr);
                        //Console.WriteLine(line);
                        //Console.WriteLine("current frame count: " + totalFrameCount);
                        //Console.WriteLine(currentFramestr);
                        //
                        // formRef.updateMyPercentage(currentFramestr);

                        //float ttt = (float) currentFrameInt / totalFrameCount;
                        //Console.WriteLine(ttt);

                        //formRef.backgroundWorker1.ReportProgress(Convert.ToInt32(ttt) * 10000);
                        formRef.backgroundWorker1.ReportProgress(currentFrameInt);
                    }
                    //Console.WriteLine(line);
                }
                
                //background thread needs to wait for ffmpeg to complete before updating UI elements!
                myProcess.WaitForExit();
                

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}