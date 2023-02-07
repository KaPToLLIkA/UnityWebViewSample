using Assets.Scripts.SysInfo;
using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Scripts.SysInfo
{
    public class SystemInfoViewer : MonoBehaviour
    {
        [SerializeField] private GameObject _textPrefab;
        [SerializeField] private GameObject _textsSpawnRoot;

        private void Awake()
        {
            PropertyInfo[] properties = typeof(SystemInfo).GetProperties(BindingFlags.Static | BindingFlags.Public);

            foreach(PropertyInfo info in properties)
            {
                CreateNewTextItem(info.Name, info.GetValue(null).ToString());
            }

            //CreateNewTextItem(nameof(SystemInfo.batteryLevel), SystemInfo.batteryLevel.ToString());
            //CreateNewTextItem(nameof(SystemInfo.batteryStatus), SystemInfo..ToString());
            //CreateNewTextItem(nameof(SystemInfo.computeSubGroupSize), SystemInfo..ToString());
            //CreateNewTextItem(nameof(SystemInfo.constantBufferOffsetAlignment), SystemInfo..ToString());
            //CreateNewTextItem(nameof(SystemInfo.copyTextureSupport), SystemInfo..ToString());
            //CreateNewTextItem(nameof(SystemInfo.deviceModel), SystemInfo..ToString());
            //CreateNewTextItem(nameof(SystemInfo.deviceName), SystemInfo..ToString());
            //CreateNewTextItem(nameof(SystemInfo.deviceType), SystemInfo..ToString());
            //CreateNewTextItem(nameof(SystemInfo.deviceUniqueIdentifier), SystemInfo..ToString());
            //CreateNewTextItem(nameof(SystemInfo.graphicsDeviceID), SystemInfo..ToString());
            //CreateNewTextItem(nameof(SystemInfo.graphicsDeviceName), SystemInfo..ToString());
            //CreateNewTextItem(nameof(SystemInfo.graphicsDeviceType), SystemInfo..ToString());
            //CreateNewTextItem(nameof(SystemInfo.graphicsDeviceVendor), SystemInfo..ToString());
            //CreateNewTextItem(nameof(SystemInfo.graphicsDeviceVendorID), SystemInfo..ToString());
            //CreateNewTextItem(nameof(SystemInfo.graphicsDeviceVersion), SystemInfo..ToString());
            //CreateNewTextItem(nameof(SystemInfo.graphicsMemorySize), SystemInfo..ToString());
            //CreateNewTextItem(nameof(SystemInfo.graphicsMultiThreaded), SystemInfo..ToString());
            //CreateNewTextItem(nameof(SystemInfo.graphicsPixelFillrate), SystemInfo..ToString());
            //CreateNewTextItem(nameof(SystemInfo.graphicsShaderLevel), SystemInfo..ToString());
            //CreateNewTextItem(nameof(SystemInfo.graphicsUVStartsAtTop), SystemInfo..ToString());
            //CreateNewTextItem(nameof(SystemInfo.hasDynamicUniformArrayIndexingInFragmentShaders), SystemInfo..ToString());
            //CreateNewTextItem(nameof(SystemInfo.hasHiddenSurfaceRemovalOnGPU), SystemInfo..ToString());
            //CreateNewTextItem(nameof(SystemInfo.hasMipMaxLevel), SystemInfo..ToString());
            //CreateNewTextItem(nameof(SystemInfo.hdrDisplaySupportFlags), SystemInfo..ToString());
            //CreateNewTextItem(nameof(SystemInfo.maxAnisotropyLevel), SystemInfo..ToString());
            //CreateNewTextItem(nameof(SystemInfo.maxComputeBufferInputsCompute), SystemInfo..ToString());
            //CreateNewTextItem(nameof(SystemInfo.maxComputeBufferInputsDomain), SystemInfo..ToString());
            //CreateNewTextItem(nameof(SystemInfo.maxComputeBufferInputsFragment), SystemInfo..ToString());
            //CreateNewTextItem(nameof(SystemInfo.maxComputeBufferInputsGeometry), SystemInfo..ToString());
            //CreateNewTextItem(nameof(SystemInfo.), SystemInfo..ToString());
            //CreateNewTextItem(nameof(SystemInfo.), SystemInfo..ToString());
            //CreateNewTextItem(nameof(SystemInfo.), SystemInfo..ToString());
            //CreateNewTextItem(nameof(SystemInfo.), SystemInfo..ToString());
            //CreateNewTextItem(nameof(SystemInfo.), SystemInfo..ToString());
            //CreateNewTextItem(nameof(SystemInfo.), SystemInfo..ToString());
            //CreateNewTextItem(nameof(SystemInfo.), SystemInfo..ToString());
            //CreateNewTextItem(nameof(SystemInfo.), SystemInfo..ToString());
        }

        private void CreateNewTextItem(string name, string value)
        {
            Debug.Log($"{name} {value}");

            var newObject = Instantiate(_textPrefab, _textsSpawnRoot.transform);
            TextItem textItem = newObject.GetComponent<TextItem>();

            textItem.Name = name;
            textItem.Value = value;
        }
    }
}
