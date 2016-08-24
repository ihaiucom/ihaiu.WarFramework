using UnityEngine;
using System.Collections;

public class WarLaunch : MonoBehaviour 
{
	void Start () 
    {
        StartCoroutine(Install());
	}

    IEnumerator Install()
    {
        yield return new WaitForEndOfFrame();

//		WaitGenerateData
//		Load
//		WaitLoad
//		GenerateStage
//		SettingEnvironment
//		WaitStart
//		Start
    }


}
