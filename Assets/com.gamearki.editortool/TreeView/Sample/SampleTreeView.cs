using UnityEngine;

namespace GameArki.EditorTool.TreeView.Sample {

    public class SampleTreeView : MonoBehaviour {

        TreeViewWindow window;

        void Awake() {

            window = TreeViewFactory.CreateTreeViewWindow();

            window.AddElement(0, -1, "Root");
            window.AddElement(1, 0, "C1");
            window.AddElement(2, 0, "C2");
            window.AddElement(3, 1, "C3");
            window.AddElement(4, 1, "C4");
            window.AddElement(5, 1, "C5");
            window.AddElement(6, 2, "C6");

        }

        void OnApplicationQuit() {
            Destroy(window.gameObject);
        }

    }

}