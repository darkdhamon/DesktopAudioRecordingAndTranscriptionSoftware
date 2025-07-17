using System.Collections.Generic;
using NAudio.CoreAudioApi;

namespace AudioRecorder
{
    /// <summary>
    /// Provides methods to enumerate available audio input and output devices.
    /// </summary>
    public class AudioDeviceEnumerator
    {
        private readonly MMDeviceEnumerator _enumerator = new();

        /// <summary>
        /// Lists all available capture (input) devices.
        /// </summary>
        public IReadOnlyList<AudioDeviceInfo> GetInputDevices()
        {
            var devices = new List<AudioDeviceInfo>();
            var defaultId = _enumerator.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Console).ID;
            foreach (var device in _enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active))
            {
                devices.Add(new AudioDeviceInfo(device.ID, device.FriendlyName, device.ID == defaultId));
            }
            return devices;
        }

        /// <summary>
        /// Lists all available render (output) devices.
        /// </summary>
        public IReadOnlyList<AudioDeviceInfo> GetOutputDevices()
        {
            var devices = new List<AudioDeviceInfo>();
            var defaultId = _enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Console).ID;
            foreach (var device in _enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active))
            {
                devices.Add(new AudioDeviceInfo(device.ID, device.FriendlyName, device.ID == defaultId));
            }
            return devices;
        }
    }
}
