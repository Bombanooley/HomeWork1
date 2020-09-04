using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Fract
    {
        private int a, b;

        public int A
        {
            get { return a; }
            set { a = value; }
        }
        public int B
        {
            get { return b; }
            set { b = value; }
        }
        public Fract (int A, int B)
        {
            a = A;
            b = B;
        }
        static public Fract operator +(Fract x, Fract y)
        {
            int NODx = x.B, NODy = y.B;
            while (NODx != NODy)
            {
                if (NODx > NODy) NODx -= NODy;
                else NODy -= NODx;
            }
            int NOK = x.B * y.B / NODx;
            int MULTx = NOK / x.B, MULTy = NOK / y.B;
            int RES = x.A * MULTx + y.A * MULTy;
            return new Fract(A: RES,B: NOK);            
        }
        static public Fract operator -(Fract x, Fract y)
        {
            int NODx = x.B, NODy = y.B;
            while (NODx != NODy)
            {
                if (NODx > NODy) NODx -= NODy;
                else NODy -= NODx;
            }
            int NOK = x.B * y.B / NODx;
            int MULTx = NOK / x.B, MULTy = NOK / y.B;
            int RES = x.A * MULTx - y.A * MULTy;
            return new Fract(A: RES, B: NOK);
        }
        static public Fract operator *(Fract x, Fract y)
        {
            return new Fract(x.A * y.A, x.B * y.B);
        }
        static public Fract operator /(Fract x, Fract y)
        {
            return new Fract(x.A * y.B, x.B * y.A);
        }
        public override string ToString()
        {
            string line = "", space = "";
            int count;
            int aSimp = a, bSimp = b;
            for (int i = Math.Max(aSimp, bSimp); i != 1; i--)                                           //Упрощение
            {
                if (aSimp % i == 0 && bSimp % i == 0)
                {
                    aSimp = aSimp / i;
                    bSimp = bSimp / i;
                }
            }
            if (aSimp < 0 && bSimp < 0)                                                                 //Проверка знака
            {
                aSimp = -aSimp;
                bSimp = -bSimp;
            }
            if (a == 0) return "0";
            if (Convert.ToString(a).Length > Convert.ToString(b).Length)                                    //Числитель длинее
            {
                for (int i = 1; i <= Convert.ToString(a).Length; i++) line += "-";                             //Линия
                count = (Convert.ToString(a).Length / 2 + 1) - (Convert.ToString(b).Length / 2);            
                for (int i = 1; i < count ; i++)                                                               //Отступ   
                    space += " ";
                
                string simple = $"{aSimp}\n{line}\n{space + bSimp}", 
                       original = $"{a}\n{line}\n{space + b}";

                if (simple == original) return original;
                else return $"{original}\n\nМожно упросить до:\n{simple}";
            }
            else if (Convert.ToString(a).Length < Convert.ToString(b).Length)                               //Знаменатель длинее        
            {
                for (int i = 1; i < Convert.ToString(b).Length; i++) line += "-";                             //Линия    
                count = (Convert.ToString(a).Length / 2 + 1) - (Convert.ToString(b).Length / 2);                
                for (int i = 1; i < count; i++)                                                               //Отступ
                    space += " ";
                string simple = $"{space + aSimp}\n{line}\n{bSimp}",
                       original = $"{space + a}\n{line}\n{b}";

                if (simple == original) return original;
                else return $"{original}\n\nМожно упросить до:\n{simple}";
            }                                                                                  
            else                                                                                //Числитель и знаменатель равноразмерны
            {
                for (int i = 1; i <= Convert.ToString(a).Length; i++) line += "-";                //Линия
                string simple = $"{aSimp}\n{line}\n{bSimp}",
                       original = $"{a}\n{line}\n{b}";
                if (simple == original) return original;
                else return $"{original}\n\nМожно упросить до:\n{simple}";
            }
        }

        
    }
}
