# BSU.ASP.1501.Day9.Berezovsky

Задание 1.

Разработать обобщенный класс, реализующий бинарное дерево поиска. Рассмотреть возможности использования 

подключаемого интерфейса для реализации отношения порядка. 

Реализовать три способа обхода дерева: прямой (preorder), поперечный (inorder), обратный (postorder): для 

реализации использовать блок-итератор (yield). 

Протестировать разработанный класс, используя в качестве аргумента типа следующие типы:

 числовой тип (использовать сравнение по умолчанию и подключаемый компаратор, например, 

сравнивающий два числа по количеству цифр в них)

 string (использовать сравнение по умолчанию и подключаемый компаратор, например, сравнивающий 

строки по длине)

 пользовательский класс Book (см. предыдущее задание), реализующий интерфейс IComparable 

(использовать сравнение по умолчанию и подключаемый компаратор)

 пользовательскую структуру Point2D, не реализующую интерфейс IComparable.

Полезные ссылки на тему «Итераторы»

http://sergeyteplyakov.blogspot.com/2010/06/c-1.html

http://sergeyteplyakov.blogspot.com/2010/06/c-2.html

http://sergeyteplyakov.blogspot.com/2010/06/c-3.html

http://www.rsdn.ru/article/alg/binstree.xml