namespace AudioRecorder
{
    /// <summary>
    /// Simple representation of an audio device.
    /// </summary>
    /// <param name="Id">System identifier for the device.</param>
    /// <param name="Name">Friendly name of the device.</param>
    /// <param name="IsDefault">Indicates whether this is the default device for the system.</param>
    public record AudioDeviceInfo(string Id, string Name, bool IsDefault);
}
