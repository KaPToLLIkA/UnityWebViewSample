using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Scripts
{
    [RequireComponent(typeof(WebViewObject))]
    public class WebViewerService : MonoBehaviour
    {
        [SerializeField] private bool _initOnAwake = false;
        [SerializeField] private bool _visibleAfterInit = true;

        [Header("Web view Settings")]
        [SerializeField] private bool _allowBackForwardNavGestures = false;
        [SerializeField] private bool _transparent = false;
        [SerializeField] private bool _zoom = true;
        [SerializeField] private bool _androidForceDarkMode = false;
        [SerializeField] private bool _enableWKWebView = true;

        [SerializeField] private Vector2Int _leftTopMargins = Vector2Int.zero;
        [SerializeField] private Vector2Int _rightBottomMargins = Vector2Int.zero;

        private WebViewObject _webViewObject;

        private void Awake()
        {
            _webViewObject = GetComponent<WebViewObject>();

            if (_initOnAwake)
            {
                Initialize();
            }
        }

        public void Initialize()
        {
            _webViewObject.Init(
                cb: OnCallFromJs, 
                err: OnError,
                httpErr: OnHttpError,
                ld: OnLoaded,
                started: OnStarted,
                hooked: OnHooked,
                transparent: _transparent,
                zoom: _zoom,
                ua: "",
                radius: 0,
                androidForceDarkMode: Convert.ToInt32(_androidForceDarkMode),
                enableWKWebView: _enableWKWebView,
                wkContentMode: 0,
                wkAllowsLinkPreview: true,
                wkAllowsBackForwardNavigationGestures: _allowBackForwardNavGestures,
                separated: false);
            
            _webViewObject.SetMargins(
                _leftTopMargins.x, _leftTopMargins.y,
                _rightBottomMargins.x, _rightBottomMargins.y);

            if (_visibleAfterInit)
            {
                _webViewObject.SetVisibility(true);
            }
        }

        public void LoadURL(string url)
        {
            _webViewObject.LoadURL(url);
            
            if (!_visibleAfterInit && !_webViewObject.GetVisibility())
            {
                _webViewObject.SetVisibility(true);
            }
        }

        private void LogMsgToConsole(string prefix, string msg)
        {
            if (Debug.isDebugBuild)
            {
                Debug.Log($"{prefix}: {msg}");
            }
        }

        private void OnCallFromJs(string msg)
        {
            LogMsgToConsole(nameof(OnCallFromJs), msg);
        }

        private void OnError(string msg)
        {
            LogMsgToConsole(nameof(OnError), msg);
        }

        private void OnHttpError(string msg)
        {
            LogMsgToConsole(nameof(OnHttpError), msg);
        }

        private void OnStarted(string msg)
        {
            LogMsgToConsole(nameof(OnStarted), msg);
        }

        private void OnLoaded(string msg)
        {
            LogMsgToConsole(nameof(OnLoaded), msg);
        }

        private void OnHooked(string msg)
        {
            LogMsgToConsole(nameof(OnHooked), msg);
        }
    }
}