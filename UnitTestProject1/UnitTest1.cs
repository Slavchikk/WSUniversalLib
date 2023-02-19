using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WSUniversalLib;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1

    {
        [TestMethod]
        public void GetQuantityForProduct_WidthIs0() // ширина = 0
        {
            float width = 0, length = 5;
            int count = 5, productType = 1, materialType = 1;
            double execept = -1;
            Calculation calculation = new Calculation();
            double actual = calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(execept, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_LengthIs0() // длина = 0
        {
            float width = 5, length = 0;
            int count = 5, productType = 1, materialType = 1;
            double execept = -1;
            Calculation calculation = new Calculation();
            double actual = calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(execept, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_CountProdIs0() // количество = 0
        {
            float width = 5, length = 5;
            int count = 0, productType = 1, materialType = 1;
            double execept = -1;
            Calculation calculation = new Calculation();
            double actual = calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(execept, actual);
        }

     

        [TestMethod]
        public void GetQuantityForProduct_AllIs0() //все равно 0
        {
            float width = 0, length = 0;
            int count = 0, productType = 0, materialType = 0;
            double execept = -1;
            Calculation calculation = new Calculation();
            double actual = calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(execept, actual);
        }
        [TestMethod]
        public void GetQuantityForProduct_CheckNotExistProductType() // введенного типа продукта нет
        {
            float width = 5, length = 5;
            int count = 5, productType = 5, materialType = 1;
            double execept = -1;
            Calculation calculation = new Calculation();
            double actual = calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(execept, actual);
        }
        [TestMethod]
        public void GetQuantityForProduct_CheckNotExistMaterial() // несуществующий тип материала
        {
            float width = 5, length = 5;
            int count = 5, productType = 1, materialType = 5;
            double execept = -1;
            Calculation calculation = new Calculation();
            double actual = calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(execept, actual);
        }
        [TestMethod]
        public void GetQuantityForProduct_WidthIs150_LengthIs155_CountProdIs36000000_TypeProdIs1_MaterialIs1_ReturnIsMin1() //Большое количество деталей
        {
            float width = 150;
            int length = 155, count = 36000000, productType = 1, materialType = 1;
            double execept = -1;
            Calculation calculation = new Calculation();
            double actual = calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(execept, actual);
        }

       
        [TestMethod]
        public void GetQuantityForProduct_WidthIs5and5_LengthIs5_CountProdIs5_TypeProdIs1_MaterialIs1() //ширина в виде  дробного числа
        {
            float width = (float)5.5;
            int length = 5, count = 5, productType = 1, materialType = 1;
            double execept = 151;
            Calculation calculation = new Calculation();
            double actual = calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(execept, actual);
        }
        [TestMethod]
        public void GetQuantityForProduct_WidthIs5_LengthIs5And5_CountProdIs5_TypeProdIs1_MaterialIs1() // длина в виде  дробного числа
        {
            float width = 5, length = (float)5.5;
            int count = 20, productType = 1, materialType = 1;
            double execept = 606;
            Calculation calculation = new Calculation();
            double actual = calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(execept, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_WidthIsMin1_LengthMin1_CountProdIs5_TypeProdIs1_MaterialIs1() //ширина  и длина отрицательные числа
        {
            float width = -1;
            int length = -1, count = 5, productType = 1, materialType = 1;
            double execept = -1;
            Calculation calculation = new Calculation();
            double actual = calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(execept, actual);
        }
        [TestMethod]
        public void GetQuantityForProduct_WidthIs455_LengthIs55_CountProdIs250_TypeProdIs2_MaterialIs2() //простая проверка
        {
            float width = 455, length = 55;
            int count = 250, productType = 2, materialType = 2;
            double execept = 15659393;
            Calculation calculation = new Calculation();
            double actual = calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(execept, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_WidthIs200000_LengthIs250000_CountProdIs100_TypeProdIs2_MaterialIs2() //большие числа 
        {
            float width = 200000, length = 250000;
            int count = 250, productType = 1, materialType = 1;
            double execept = -1;
            Calculation calculation = new Calculation();
            double actual = calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(execept, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_WidthIs1100_LengthIs1400_CountProdIs100_TypeProdIs3_MaterialIs1() //Приблизительно максимально большие числа для  корректной работы
        {
            float width = 1100, length = 1400;
            int count = 100, productType = 3, materialType = 1;
            double execept = 1302114660;
            Calculation calculation = new Calculation();
            double actual = calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(execept, actual);
        }
        [TestMethod]
        public void GetQuantityForProduct_WidthIs09_LengthIs09_CountProdIs1_TypeProdIs3_MaterialIs1() // маленькие числами
        {
            float width = (float)0.9, length = (float)0.9;
            int count = 1, productType = 3, materialType = 1;
            double execept = 6;
            Calculation calculation = new Calculation();
            double actual = calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(execept, actual);
        }
        [TestMethod]
        public void GetQuantityForProduct_WidthIs00000000001_LengthIs00000000001_CountProdIs1_TypeProdIs2_MaterialIs2() //очень маленькие числами
        {
            float width = (float)0.0000000001, length = (float)0.0000000001;
            int count = 1, productType = 3, materialType = 1;
            double execept = 0;
            Calculation calculation = new Calculation();
            double actual = calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(execept, actual);
        }
    }
}
