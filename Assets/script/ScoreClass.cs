using UnityEngine;
using System.Collections;

public static class ScoreClass {
    private static int score;
    private static int lifes;
    public static int Score { get { return score; } set { ScoreClass.score = value; } }
    public static int Lifes { get { return lifes; } set { ScoreClass.lifes = value; } }
}
