using UnityEngine;

namespace Tableau
{
    public abstract class TableauBase: MonoBehaviour
    {
        public abstract void SetTitle(string title);
        public abstract void SetDescription(string description);
        public abstract void Close();
    }
}