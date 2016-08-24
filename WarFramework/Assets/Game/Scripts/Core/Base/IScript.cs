using UnityEngine;
using System.Collections;
namespace Games
{
    public interface IScript 
	{
		/** 重置 */
        void CReset();
		
		/** 释放 */
        void CRelease();
		
		/** 销毁,内存 */
        void CDealloc();
	}

}