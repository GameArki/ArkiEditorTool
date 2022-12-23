using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GameArki.EditorTool.TreeView {

    public class TreeViewElement : MonoBehaviour {

        public int id;
        public int parentID;

        Text text;
        Transform groupBD;
        public Transform GroupBD => groupBD;

        public void Ctor() {
            text = GetComponentInChildren<Text>();
            groupBD = transform.GetChild(1);

            Debug.Assert(text != null);
        }

        public void SetName(string name) {
            text.text = name;
        }

    }

}
