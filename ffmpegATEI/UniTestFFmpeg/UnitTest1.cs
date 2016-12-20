using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ffmpegATEI;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace UniTestFFmpeg
{
    [TestClass]
    public class UnitTest1
    {
        ffPresets testffPreset = new ffPresets(null);
        string input = "C:\\Users\\user1\\Desktop\\uniTestin.mp4";
        string output = "C:\\Users\\user1\\Desktop\\testin";
        string expectedOutput = "";
        string preset = "";
        bool flug = false;
        [TestMethod]
        public void presetVideoOnly()
        {
            bool closed = false;
            expectedOutput = "C:\\Users\\user1\\Desktop\\testin\\VideoOnly.mp4";
            testffPreset.detectPreset(input, output, "Video Only", null, 100);
            Thread.Sleep(5000);//we need this dead duration to ensure that ffmpeg 
            //have already closed its streams.
            while (!closed)
            {
                try
                {
                    if (File.Exists(expectedOutput))
                    {
                        File.Delete(expectedOutput);
                        flug = true;
                    }
                    closed = true;
                }
                catch (IOException exc)
                {
                    Console.WriteLine(exc.ToString() + Environment.NewLine + "the streams"
                        + "of ffmpeg ,delay to close a little bit this time");
                }
                Assert.IsTrue(flug);
                flug = false;
            }
        }//end of testing video only

        [TestMethod]
        public void presetPSP()
        {
            bool closed = false;
            expectedOutput = "C:\\Users\\user1\\Desktop\\testin\\PSP.mp4";
            testffPreset.detectPreset(input, output, "PSP", null, 100);
            foreach (Process proc in Process.GetProcesses())
            {
                Console.WriteLine(proc.ProcessName);
                if (proc.ProcessName.Equals("ffmpeg"))
                {
                    proc.Kill();
                }
            }
            while (!closed)
            {
                try
                {
                    if (File.Exists(expectedOutput))
                    {
                        File.Delete(expectedOutput);
                        flug = true;
                    }
                    closed = true;
                }
                catch (IOException exc)
                {
                    Console.WriteLine(exc.ToString() + Environment.NewLine + "the streams"
                        + "of ffmpeg ,delay to close a little bit this time");
                }
            }
            Assert.IsTrue(flug);
            flug = false;
        }//end of testing psp preset

        [TestMethod]
        public void presetAudioOnly()
        {
            bool closed = false;
            expectedOutput = "C:\\Users\\user1\\Desktop\\testin\\AudioOnly.m4a";
            testffPreset.detectPreset(input, output, "Audio Only", null, 100);
            while (!closed)
            {
                try
                {
                    if (File.Exists(expectedOutput))
                    {
                        File.Delete(expectedOutput);
                        flug = true;
                    }
                    closed = true;
                }
                catch (IOException exc)
                {
                    Console.WriteLine(exc.ToString() + Environment.NewLine + "the streams"
                        + "of ffmpeg delayed to close a little bit this time");
                }
            }
            Assert.IsTrue(flug);
            flug = false;
        }//end of testing audio only preset
    }//end of class UnitTest1
}
