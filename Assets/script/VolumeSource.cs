using UnityEngine;
using System.Collections;

public static class VolumeSource  {
    private static float volume = 1;
    public static float Volume { get { return volume; } set { VolumeSource.volume = value; } }
}
