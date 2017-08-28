﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using OnlyR.Services.Audio;
using OnlyR.Services.Options;
using OnlyR.Services.RecordingDestination;

namespace OnlyR.Tests.Mocks
{
    public static class MockGenerator
    {
        public static IAudioService CreateAudioService()
        {
            return new MockAudioService();
        }

        public static Mock<IOptionsService> CreateOptionsService()
        {
            return new Mock<IOptionsService>();
        }

        public static Mock<IRecordingDestinationService> CreateRecordingsDestinationService()
        {
            return new Mock<IRecordingDestinationService>();
        }
    }
}