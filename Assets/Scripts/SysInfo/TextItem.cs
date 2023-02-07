using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.SysInfo
{
    public class TextItem : MonoBehaviour
    {
        [SerializeField] private TMP_Text _name;
        [SerializeField] private TMP_Text _value;

        public string Name 
        { 
            get 
            { 
                return _name.text; 
            } 
            set 
            { 
                _name.text = value; 
            } 
        }
        public string Value 
        { 
            get 
            { 
                return _value.text;
            } 
            set {
                _value.text = value;
            } 
        }
    }
}
