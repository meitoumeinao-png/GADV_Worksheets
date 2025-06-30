using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GADVDataTypes
{
    public class SpriteScaler : MonoBehaviour
    {
        private Transform spriteTransform;
        //private string scale = "2.0a";
        private string scale = "2.0";
        void Start()
        {
            float scalevalue = float.Parse(scale);
            spriteTransform = GetComponent<Transform>();
            spriteTransform.localScale = new Vector3(scalevalue, scalevalue, 1f);
        }
    }
}
