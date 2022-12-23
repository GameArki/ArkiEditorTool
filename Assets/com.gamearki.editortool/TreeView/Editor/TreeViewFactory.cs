using UnityEngine;

namespace GameArki.EditorTool.TreeView {

    public static class TreeViewFactory {

        public static TreeViewWindow CreateTreeViewWindow() {

            var prefab = Resources.Load<TreeViewWindow>("tree_view_window");
            var window = GameObject.Instantiate(prefab);
            window.Ctor();
            return window;

        }

    }
}