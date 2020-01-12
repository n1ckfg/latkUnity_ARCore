using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectScreenPos : MonoBehaviour {

    public Vector2 margin = Vector2.zero;

    private bool firstRun = true;

    void Update() {
        if (firstRun) {
            Vector3 newPos = Camera.main.ScreenToWorldPoint(new Vector3(margin.x - (Screen.width / 2), (Screen.height + (Screen.height / 2)) - margin.y, 1f));
            transform.localPosition = new Vector3(newPos.x, newPos.y, transform.localPosition.z);

            firstRun = false;
        }
    }

}
