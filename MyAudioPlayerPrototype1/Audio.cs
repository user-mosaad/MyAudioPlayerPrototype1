enum AudioState
{
    Stopped,
    Playing,
    Paused
}

class Audio
{
    public required string Path { get; set; }
    public required string Name { get; set; }
    public required TimeOnly Duration { get; set; }
    public required bool Repeat { get; set; }
    public required AudioState State { get; set; }

    public Audio(string path, string name, TimeOnly duration, bool repeat, AudioState state)
    {
        Path = path;
        Name = name;
        Duration = duration;
        Repeat = repeat;
        State = state;
    }

    public void PlayAudio()
    {
        State = AudioState.Playing;
    }
}