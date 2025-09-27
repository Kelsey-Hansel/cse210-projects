using System;

class Program
{
    static void Main(string[] args)
    {
        Order orderOne = new Order();
        Order orderTwo = new Order();

        orderOne.MakeCustomer("Shea Gibb", "123 Main Street", "Wichita", "Kansas", "USA");
        
        orderOne.MakeProductList("Shampoo Vanilla Scent", "S52P73", 5.89f, 2);
        orderOne.MakeProductList("Conditioner Vanilla Scent", "C82D39", 6.95f, 3);
        orderOne.MakeProductList("Body Wash Unscented", "B09W82", 5.45f, 2);

        orderOne.DisplayPackingLabel();
        orderOne.DisplayShippingLabel();

        orderTwo.MakeCustomer("Mariska Mikulová", "Szent Imre ter 2", "Baja", "Bács-Kiskun", "Hungary");

        orderTwo.MakeProductList("Shampoo Pomegranate Scent", "S52P74", 5.89f, 4);
        orderTwo.MakeProductList("Conditioner Pomegranate Scent", "C82D37", 6.95f, 5);
        orderTwo.MakeProductList("Body Wash Coconut Scent", "B09W84", 5.45f, 1);

        orderTwo.DisplayPackingLabel();
        orderTwo.DisplayShippingLabel();
    }
}