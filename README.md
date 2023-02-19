### Проект "WSUniversalLib" 

Проект предназначен для подсчета необходимого  <i>сырья</i>


## Начало работы

Для работы с данным приложением потребуется Visual Studio.
1. Откройте проект на github: https://github.com/Slavchikk/WSUniversalLib.git
2. Нажмите на кнопку <B>Code</B> в правом верхнем углу
3. Скопируйте ссылку и вставьте в Visual Studio в вкладке `клонированить репозиторий` или нажмите на `Download zip`


### Необходимые условия :warning:

1. <B>Visual Studio</B>
  + Зайти на сайт https://visualstudio.microsoft.com/downloads
  + Установить нужную версию
2. <B>Наличие места на диске</B>
3. <B>Остальные подходящие характеристики компьтера для работы с VS</B>


## Тестирование

<b>В Visual Studio</b>
+ Запуск проекта
  + Перейти в UnitTestProject1
  + Во вкладке тест выбрать запуск всех тестов
  
Пример кода теста
```
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
```
 Результаты всех тестов:


![img](https://github.com/Slavchikk/WSUniversalLib/blob/master/all.png)


## Автор :underage: :shipit: :no_entry:

 :neckbeard: **Вячеслав Александрович** - *Kinoteatr* - [Мой аккаунт на GitHub](https://github.com/Slavchikk)

Так же посмотрите маркет машин [здесь](https://github.com/Slavchikk/CarsProject) пожалеете.



<!--
**Slavchikk/Slavchikk** is a ✨ _special_ ✨ repository because its `README.md` (this file) appears on your GitHub profile.

Here are some ideas to get you started:

- 🔭 I’m currently working on ...
- 🌱 I’m currently learning ...
- 👯 I’m looking to collaborate on ...
- 🤔 I’m looking for help with ...
- 💬 Ask me about ...
- 📫 How to reach me: ...
- 😄 Pronouns: ...
- ⚡ Fun fact: ...
-->
