﻿using UnityEngine;
using System.Collections;

public static class ScenesSource{
    private static string SceneName = "Menu";
    public static bool canContinue { get { return canContinue; } set { ScenesSource.canContinue = value;  } }
    public static string Name { get { return SceneName; } set { ScenesSource.SceneName = value; } }
}
