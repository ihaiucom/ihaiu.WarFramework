using UnityEngine;
using System.Collections;

namespace Games.Wars
{
    public interface IPause 
    {
        /** 暂停 */
        void Pause ();


        /** 继续 */
        void Resume ();
    }
}
