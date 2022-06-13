# PanzerdogTestTask
Тестовое задание в студию Panzerdog (My Games)
Версия Unity: 2020.3.11f1

## Показ результата
Общий вид магазина при запуске
![image](https://user-images.githubusercontent.com/57954863/173400702-d21aa23d-942e-4c5c-8bbb-8ae6a9317504.png)

Подтверждение или отмена покупки
![image](https://user-images.githubusercontent.com/57954863/173401008-ca98f64a-1932-41fd-a365-9bb06e1f6983.png)

Сообщение, если не хватает денег
![image](https://user-images.githubusercontent.com/57954863/173401188-67cd9c66-60de-4726-80f3-0b13dd84b11d.png)

## Основные компоненты в инспекторе для настройки магазина
*Примечание: все основные параметры по настройке находятся в пустышке "Managers" на сцене Main.
+ Настройка денег у пользователя при старте игры
  
  Для этого нужно перейти в "Managers" -> "User". И в скрипте "User" выкрутить ползунок "Initial Amount" на нужное значение.
  
  ![image](https://user-images.githubusercontent.com/57954863/173401981-f1b32fab-0200-45ca-b955-7cd1130de4ea.png)
+ Добавление новых продуктов в магазин
  1. Прежде чем добавлять новый продукт в магазин, его нужно создать. Для этого Перейдем в "Assets" -> "CreatedProducts". В данной папке я храню все созданные продукты. В папке нажимаем ПКМ и выбираем "Create" -> "Blocks" -> "Интересующий вас блок".
  
  ![image](https://user-images.githubusercontent.com/57954863/173402514-d90b2f1f-30ab-4b59-a28b-98e6c164b270.png)
  
  2. После создания блока, его нужно настроить. В примере ниже показан продукт string + string
  ![image](https://user-images.githubusercontent.com/57954863/173403036-a5002588-4a58-4a0d-a541-ab8ec84976a0.png)

  4. Теперь переходим в иерархию "Managers" -> "Shop". В скрипте "Shop" есть список элементов, добавляем сюда созданный продукт.

  ![image](https://user-images.githubusercontent.com/57954863/173402841-5288114a-a8af-47de-9a77-b38b58c0abe4.png) 

