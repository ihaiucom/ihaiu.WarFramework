using UnityEngine;
using System.Collections;
using System;

namespace Games.Wars
{
	/** 实体行为 */
    public class EMonoBehaviour : MonoBehaviour, IEComponent 
	{


        /** 重置, 用在对象池 */
        virtual public void CReset()
        {
        }

        /** 释放,一般用在销毁或对象池释放 */
        virtual public void CRelease()
        {
        }


        /** 销毁内存分配 */
        virtual public void CDealloc()
        {
        }



	}
}
