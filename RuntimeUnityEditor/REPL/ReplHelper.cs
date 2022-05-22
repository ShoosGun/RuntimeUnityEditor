using System.Collections;
using UnityEngine;

namespace RuntimeUnityEditor.Core.REPL
{
    public class ReplHelper : MonoBehaviour
    {
        public T Find<T>() where T : Object
        {
            return (T)FindObjectOfType(typeof(T));
        }

        public T[] FindAll<T>() where T : Object
        {
            return (T[])FindObjectsOfType(typeof(T));
        }

        public Coroutine RunCoroutine(IEnumerator i)
        {
            return StartCoroutine(i);
        }

        public void EndCoroutine(Coroutine c)
        {
            StopCoroutine(c.ToString());
        }
    }
}