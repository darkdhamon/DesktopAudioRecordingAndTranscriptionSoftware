# DesktopAudioRecordingAndTranscriptionSoftware

This library provides utilities to enumerate audio input and output devices on the host system.

### Enumerating devices

```
var enumerator = new AudioRecorder.AudioDeviceEnumerator();
var inputs = enumerator.GetInputDevices();
var outputs = enumerator.GetOutputDevices();
```

Each `AudioDeviceInfo` contains the system identifier, friendly name and whether it is the default device.

