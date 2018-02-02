using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tamesi : MonoBehaviour {

    void Update()
    {
        foreach (Touch t in Input.touches) //画面にタッチされた指の数をtに入れる
        {
            var id = t.fingerId;

            switch (t.phase) {          //tの数だけ↓を繰り返す
                case TouchPhase.Began: //画面に指がタッチされたら
                    if (t.position.x > Screen.width / 2 && tag == "RightFripperTag") { }
                        break;

                case TouchPhase.Ended: //画面から指が離されたら
                case TouchPhase.Canceled:
                    Debug.LogFormat("{0}:いま離された", id);
                    break;
            }
        }
    }
}