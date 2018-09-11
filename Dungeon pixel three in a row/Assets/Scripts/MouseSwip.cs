using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseSwip : MonoBehaviour {

    Vector2 FirstTouch;
    Vector2 FinalTouch;

    float AngleMouseSwap;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        FirstTouch = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseUp()
    {
        FinalTouch = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        CalculateAngle();
    }

    private void CalculateAngle()
    {
        AngleMouseSwap = Mathf.Atan2(FinalTouch.y - FirstTouch.y, FinalTouch.x - FirstTouch.x) * 180.0f / Mathf.PI;
        Debug.Log(AngleMouseSwap);
    }
}
