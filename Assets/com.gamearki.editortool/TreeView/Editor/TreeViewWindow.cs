using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameArki.EditorTool.TreeView {

    public class TreeViewWindow : MonoBehaviour {

        Canvas canvas;

        Transform bd;

        TreeViewElement elementPrefab;

        Dictionary<int, TreeViewElement> elements;

        public void Ctor() {

            elements = new Dictionary<int, TreeViewElement>();

            canvas = GetComponent<Canvas>();
            bd = transform.GetChild(0);

            elementPrefab = Resources.Load<GameObject>("tree_view_element").GetComponent<TreeViewElement>();

            Debug.Assert(canvas != null);
            Debug.Assert(bd != null);
            Debug.Assert(elementPrefab != null);

        }

        public void AddElement(int id, int parentID, string name) {

            TreeViewElement element;
            bool has = elements.TryGetValue(parentID, out TreeViewElement parent);
            if (has) {
                element = Instantiate(elementPrefab, parent.GroupBD);
            } else {
                element = Instantiate(elementPrefab, bd);
            }

            element.Ctor();

            element.id = id;
            element.parentID = parentID;
            element.SetName(name);

            elements.Add(id, element);

        }

    }

}
