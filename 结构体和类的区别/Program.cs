﻿namespace 结构体和类的区别
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 区别概述
            //结构体和类最大的区别是在存储空间上，结构体存储在栈上，类存储在堆上。一个是值类型，一个是引用类型。
            //分别对应值类型和引用类型的相应特点  赋值,传递,声明.. 

            //结构体和类在使用上很类似,结构体甚至可以用面向对象的思想去总结一类对象
            //结构体具备面向对象思想中的封装特性，但是不具备
            //由于结构体不具备继承特性，所以它不能使用protected 修饰符
            #endregion

            #region 细节区别
            //1.结构体是值类型，类是引用类型
            //2.结构体存在栈中，类存在堆中
            //3.结构体成员不能使用protected访问修饰符，而类可以
            //4.结构体成员变量申明不能指定初始值，而类可以  如果结构体成变量声明时候进行了初始化，会报错，如果实现了结构体的构造函数就不错了
            //6.结构体申明有参构造函数后，无参构造不会被顶掉
            //7.结构体不能申明析构函数，而类可以
            //8.结构体不能被继承，而类可以
            //9.结构体需要在构造函数中初始化所有成员变量，而类随意
            //10.结构体不能被静态static修饰(不存在静态结构体)，而类可以   结构体中可以有静态static成员变量
            //11.结构体不能在自己内部申明和自己一样的结构体变量，而类可以
            #endregion

            #region 结构体的特别之处
            //结构体可以继承接口 因为接口是行为的抽象
            #endregion

            #region 如何选择
            //1.想要用继承和多态时，直接淘汰结构体，比如玩家、怪物等等
            //2.对象是数据集合时，优先考虑结构体，比如位置、坐标等等
            //3.从值类型和引用类型赋值时的区别上去考虑，比如经常被赋值传递的对象，并且
            //改变赋值对象，原对象不想跟着变化时，就用结构体。比如坐标、向量、旋转等等
            #endregion
        }
    }
}