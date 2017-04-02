using UnityEngine;
using UnityEditor;
using NUnit.Framework;

public class Tests {

	[Test]
	public void ScoreTest()
	{
		var scoreHandler = new VirtualButtonEventHandler ();
		scoreHandler.CalculateScore (true);
		Assert.AreEqual (1, VirtualButtonEventHandler.Score);
	}

	[Test]
	public void ScoreTestMinus()
	{
		var scoreHandler = new VirtualButtonEventHandler ();
		scoreHandler.CalculateScore (false);
		Assert.AreEqual (0, VirtualButtonEventHandler.Score);
	}
		
}
