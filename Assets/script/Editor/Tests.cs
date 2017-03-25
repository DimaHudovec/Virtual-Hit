using UnityEngine;
using UnityEditor;
using NUnit.Framework;

public class Tests {

	[Test]
	public void ScoreTest()
	{
		var scoreHandler = new VirtualButtonEventHandler ();
		scoreHandler.CalculateScore (true);
		Assert.AreEqual (1, scoreHandler.Score);
	}

	[Test]
	public void ScoreTestMinus()
	{
		var scoreHandler = new VirtualButtonEventHandler ();
		scoreHandler.CalculateScore (false);
		Assert.AreEqual (0, scoreHandler.Score);
	}
		
}
