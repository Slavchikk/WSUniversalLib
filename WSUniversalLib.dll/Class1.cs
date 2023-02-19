using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib
{
    public class Calculation
    {
        public int GetQuantityForProduct(int productType, int materialType, int count,float width, float length)
        {
            if (productType != 1 && productType != 2 && productType != 3) // Существует ли такая продукция
            {
                return -1;
            }
            if (materialType != 1 && materialType != 2) // Существует ли такой материал
            {
                return -1;
            }
            if (width <= 0 || length <= 0 || count <= 0) // Длина,ширина и количество не могут быть отрицательными
            {
                return -1;
            }
            double resh = 0;

            if (width > 0 && length > 0 && count > 0)
            {
                if (productType == 1)
                {
                    if (materialType == 1)
                    {
                        resh = count * width * length * 1.1 + count * width * length * 1.1 * 0.003;
                    }
                    else 
                    {
                        resh = count * width * length * 1.1 + count * width * length * 1.1 * 0.0012;
                    }
                }
                else if (productType == 2)
                {
                    if (materialType == 1)
                    {
                        resh = count * width * length * 2.5 + count * width * length * 2.5 * 0.003;
                    }
                    else 
                    {
                        resh = count * width * length * 2.5 + count * width * length * 2.5 * 0.0012;
                    }
                }
                else if (productType == 3)
                {
                    if (materialType == 1)
                    {
                        resh = count * width * length * 8.43 + count * width * length * 8.43 * 0.003;
                    }
                    else 
                    {
                        resh = count * width * length * 8.43 + count * width * length * 8.43 * 0.0012;
                    }
                }
            }
            

            int itog = (int)resh;
            if (itog == -2147483648) //при входе из своего типа ( большое число) 
            {
                return -1;
            }
            return itog;
        }
    }
}
