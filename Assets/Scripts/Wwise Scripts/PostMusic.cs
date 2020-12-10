//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;


//public class PostMusic : MonoBehaviour {
//                  public AK.Wwise.Event MusicEvent;
//    // Use this for initialization.
//    void Start () {
//        MusicEvent.Post(gameObject, (uint)AkCallbackType.AK_MusicSyncBar, CallbackFunction);
//    }
//    void CallbackFunction(object in_cookie, AkCallbackType in_type, object in_info){
//        GameManager.PushRhythmAction();
//    }
//}