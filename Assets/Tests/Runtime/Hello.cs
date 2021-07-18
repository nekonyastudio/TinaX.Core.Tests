using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Hello
{
    // A Test behaves as an ordinary method
    [Test]
    public void HelloSimplePasses()
    {
        TestContext.Out.WriteLine("Hello World");
        Assert.Pass();
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    //[UnityTest]
    //public IEnumerator HelloWithEnumeratorPasses()
    //{
    //    // Use the Assert class to test conditions.
    //    // Use yield to skip a frame.
    //    yield return null;
    //}
}
