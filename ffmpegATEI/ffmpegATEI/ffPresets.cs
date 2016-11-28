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
        public static void detectPreset(String inputFile, String outputDirectory,String preset)
        {
            switch(preset)
            {
                case "Audio Only":
                    AudioOnly(inputFile, outputDirectory);
                    break;

                case "Video Only":
                    VideoOnly(inputFile, outputDirectory);
                    break;
                default:
                    MessageBox.Show("Incorrect preset selected!");
                    break;
            }

        }

        private void test()
        {

        }

        private static void AudioOnly(String inputFile,String outputDirectory)
        {
            //MessageBox.Show(inputFile+  "   "+outputDirectory);
            //enclose path names with " " so ffmpeg can handle spaces correctly
            String parameters = "-y -i " + '"' + inputFile + '"' + " " + '"' + outputDirectory + "\\test.mp3" + '"';
            doConvert(parameters);
        }

        private static void VideoOnly(String inputFile, String outputDirectory)
        {
            //enclose path names with " " so ffmpeg can handle spaces correctly
            String parameters = "-i " + '"' + inputFile + '"' + " -c copy -an "+" "+'"'+outputDirectory+"\\test.mp4"+'"';
            doConvert(parameters);
        }

        private static void doConvert(String parameters)
        {
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
                    Console.WriteLine(line);
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