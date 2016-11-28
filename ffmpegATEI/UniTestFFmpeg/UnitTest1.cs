using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using ffmpegATEI;

namespace UniTestFFmpeg
{
    [TestClass]
    public class UnitTest1
    {
        
        private bool flag = false;
        private string inputdir ;
        private string outputdir;
        private string outputExpected;
        [TestMethod]
        public void TestAudioOnly()
        {
            inputdir = "C:\\Windows\\Temp\\testVideo.mp4";
            outputdir = "C:\\Windows\\Temp";
            outputExpected = "C:\\Windows\\Temp\\test.mp3";
            ffPresets.detectPreset(inputdir,outputdir,"Audio Only");
            if (File.Exists(outputExpected))
            {
                flag = true;
            }
            Assert.IsTrue(flag);
            File.Delete(outputExpected);
            flag = false;
        }

        public void TestVideoOnly()
        {
            inputdir = "C:\\Windows\\Temp\\testVideo.mp4";
            outputdir = "C:\\Windows\\Temp";
            outputExpected = "C:\\Windows\\Temp\\test.mp4";
            ffPresets.detectPreset(inputdir, outputdir, "Video Only");
            if (File.Exists(outputExpected))
            {
                flag = true;
            }
            Assert.IsTrue(flag);
            File.Delete(outputExpected);
            flag = false;
        }


    }
}
