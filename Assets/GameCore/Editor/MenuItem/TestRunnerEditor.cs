using UnityEditor;
using UnityEditor.TestTools.TestRunner.Api;
using UnityEngine;

namespace GameCore.Editor
{
    public class TestRunnerEditor
    {
	    [MenuItem("Tools/RunAllUnitTest(F1)")]
		private static void RunAllUnitTest(){
			var testRunnerApi  = ScriptableObject.CreateInstance<TestRunnerApi>();
            var filterEditMode = new Filter();
            filterEditMode.testMode = TestMode.EditMode;
            var filterPlayMode = new Filter();
            filterPlayMode.testMode = TestMode.PlayMode;
            Filter[] apiFilter = { filterEditMode , filterPlayMode };
            testRunnerApi.Execute(new ExecutionSettings(apiFilter));
		}
    }
}
