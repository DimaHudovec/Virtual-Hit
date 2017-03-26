using UnityEngine;
using UnityEditor;
using NUnit.Framework;

public class ButtonTest {

	[Test]
	public void EditorTest()
	{
        var gameObject = new OptionMenu();
        gameObject.OnMouseDown();
        Assert.AreEqual(true, gameObject.GetButtonStatus());
    }

    [Test]
    public void ExitButtonTest()
    {
        var gameObject = new ExitMenu();
        gameObject.OnMouseDown();
        Assert.AreEqual(true, gameObject.GetButtonStatus());
    }
}
