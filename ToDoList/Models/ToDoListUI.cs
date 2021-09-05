using System;
using ToDoList.Models;
using System.Collections.Generic;

class ConsoleProgram{

    static void AddItem(){
        Console.Clear();
    Console.WriteLine("Please enter the description for the new item.");
    string userDescription = Console.ReadLine();
    Item newItem = new Item(userDescription);
    Main();
    }

    static void ViewItem(){
        List<Item> result = Item.GetAll();
        Console.Clear();
        Console.WriteLine("Here is your list:");
    foreach (var item in result)
    {  
        Console.WriteLine(item.Description);
    }
    }

    static void ActionChoice(string str){
        if(str == "1"){
            AddItem();
        } else if (str == "2"){
            ViewItem();
        } else {
            Main();
        }
    }

    static void Main(){
        Console.Clear();
        Console.WriteLine("Welcome to list maker, press 1 to make an item in your list, press 2 to view the whole list.");
        string userInput = Console.ReadLine();
        ActionChoice(userInput);
        }
    //   string description01 = "Walk the dog.";
    //   string description02 = "Wash the dishes.";
    //   string description03 = "Make a last minute coffee run to the coffee shop and abandon your epicodus partner like a big jerk.";
    //   Item newItem1 = new Item(description01);
      // Item newItem2 = new Item(description02);
    //   Item newItem3 = new Item(description03);
    //   List<Item> newList = new List<Item> { newItem1, newItem2, newItem3 };

    //   //Act
    //   List<Item> result = Item.GetAll();

    // //   Console.WriteLine(result);
    // foreach (var item in result)
    // {
    //     Console.WriteLine(item.Description);
    // }