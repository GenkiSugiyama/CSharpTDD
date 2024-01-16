using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.UI
{
    // 外部のRDBと接続しレコードの値を取得する、本番で動作させるクラス
    // インタフェースを実装し、接続先のDBからレコードの値を返す
    public class DB : IDB
    {
        public int GetDBValue()
        {
            // 実際はDBの値を取得し返却するが簡略化のため固定値を返す
            return 200;
        }

        public Product GetProduct()
        {
            throw new NotImplementedException();
        }

        public void SaveProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
