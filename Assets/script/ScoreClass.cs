using UnityEngine;
using System.Collections;

public static class ScoreClass {
    private static int score;
    public static int Score { get { return score; } set { ScoreClass.score = value; } }
}
