using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    [RequireComponent(typeof(WebViewObject))]
    public class WebViewerService : MonoBehaviour
    {
        private WebViewObject _webViewObject;

        private void Awake()
        {
            _webViewObject = GetComponent<WebViewObject>();
            _webViewObject.Init();
            _webViewObject.LoadURL("https://www.google.ru/");
        }
    }
}