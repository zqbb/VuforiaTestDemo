using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class T : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.DOLocalJump(new Vector3(0, 0.05f, 0), 2, 1, 1f).SetLoops(-1,LoopType.Restart) ;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit();
        }
	}
}
