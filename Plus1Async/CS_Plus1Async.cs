using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plus1Async
{
    public class CS_Plus1Async
    {
        #region 共有領域
        private int _result;        // 処理結果
        public int Result
        {   // 処理結果
            get
            {
                return (_result);
            }
            set
            {
                _result = value;
            }
        }
        #endregion

        #region コンストラクタ
        public CS_Plus1Async()
        {   // コンストラクタ
            _result = 0;            // 初期値：０
        }

        public CS_Plus1Async(int _init)
        {   // コンストラクタ
            _result = _init;        // 初期値：_init
        }
        #endregion

        #region モジュール
        public async Task ClearAsync()
        {   // 処理結果の初期化
            _result = 0;            // 初期値：０
        }

        public async Task SetAsync(int _init)
        {   // 処理結果の初期化
            _result = _init;        // 初期値：_init
        }

        public async Task ExecAsync()
        {   // 処理結果＋１
            _result++;              // 処理結果＋１
        }
        #endregion
    }
}
